import ConfigParser
import json
import os.path
import io
import yaml

# class to easily parse config files(via configParser) making python scripts configuration driven
class easierConfig():
    # constructor pass in name of file and file path (defaults to current dir)
    def __init__(self, filename,filepath = os.getcwd()):
        # name of file to parse
        self.fileName =  filename
        # path of file to parse
        self.filePath = filepath
        # default to config file type
        self.fileType = 0
        self.parseFile()
    # get file extension and determine type
    def findFileType(self):
        ext = os.path.splitext(self.fileName)[1]
        if ext == '.json':
            self.fileType = 1
        if ext == '.yml':
            self.fileType = 2
    # read configuration file
    def parseFile(self):
        self.findFileType()
        self.fileName = os.path.join(self.filePath,self.fileName)
        if self.fileType == 0:
            self.data = ConfigParser.ConfigParser()
            self.data.read(self.fileName)
        if self.fileType == 1:
            with open(self.fileName) as json_data_file:
                self.data = json.load(json_data_file)
        if self.fileType == 2:
            yaml_data = open(self.fileName, 'r')
            self.data = yaml.load(yaml_data)
    # helper function to create and return dictionary of defined section
    def configSectionMap(self,section):
        sectionDict = {}
        options = self.cfg.options(section)
        for option in options:
            try:
                sectionDict[option] = self.cfg.get(section, option)
                if sectionDict[option] == -1:
                    DebugPrint("skip: %s" % option)
            except:
                print("exception on %s!" % option)
                sectionDict[option] = None
        return sectionDict
    # create configuration file
    def createConfigFile(self,filename,section,makeSection,setDictionary,append):
            # lets create that config file for next time...
            if append == True: 
                cfgfile = open(filename,'a')
            else: 
                cfgfile = open(filename,'w')
            Config = ConfigParser.ConfigParser()
            # add the settings to the structure of the file, and lets write it out...
            if makeSection == True:
                Config.add_section(section)
            for i in setDictionary:
                Config.set(section,i,setDictionary[i])
            Config.write(cfgfile)
            cfgfile.close()
