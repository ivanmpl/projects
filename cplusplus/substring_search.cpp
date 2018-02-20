   #include <iostream>
    #include <cstring>
     
    using namespace std;
     
    bool isSubStr(char* const str,const char* const srch){
        char* substr=0;
        unsigned int k=0;
        bool found=false;
        unsigned int str_len=strlen(str); //running time = L1
        unsigned int srch_len=strlen(srch); //running time = L2 ,L2<=L1, ignore 
     
        for(unsigned int i=0;i<str_len;i++){ //running time = L1
            substr=str+i; //pointer arithmetics
            if(*substr==*(srch+k) && k<srch_len){
                k++;
                if(k>=srch_len){
                    found=true;
                    break;
                }
            }
            else{
                k=0;
                found=false;
            }
        }
     
        //overall running time =2L1+L2, with L2 negligible then final RT = L1.
        return found;
    }
     
    int main()
    {
        char* str="Hello World";
        char* srch="World";
        cout <<isSubStr(str,srch)<< endl;
        return 0;
    }