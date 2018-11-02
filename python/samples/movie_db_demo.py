#!/usr/bin/python
# -*- coding: utf-8 -*-

import MySQLdb as mdb
import requests
import sys

print "Welcome to the Gatsby Movie Theater!"
print "Our current movie collection includes:"
print "*" * 35

# Open database connection
db = mdb.connect("localhost","root","password","gatsby_theater" )

try:

    with db:
        # prepare a cursor object using cursor() method
        cursor = db.cursor()
        # execute SQL query using execute() method
        cursor.execute("SELECT * FROM movies")
        # Fetch all rows using fetchall() method
        rows = cursor.fetchall()
	    # loop through rows printing each entity
        for row in rows:
            print row[0],row[1]

except mdb.Error, e:

    print "Error %d: %s" % (e.args[0],e.args[1])
    sys.exit(1)

        
print "*" * 35
movie_num = int(raw_input("To see showtimes please enter number or 0 for more movies: "))

if movie_num == 0:
    # prompt user for title of movie
    movie_title = raw_input("Please Enter the movie title to Search For: ").replace(" ","+")
    # structure GET request to RESTful service
    movie_request = 'http://www.omdbapi.com/?t=%s' % movie_title
    # get JSON response and insert movie into db
    response = requests.get(movie_request)
    movie_dict = response.json()
    query =  "INSERT INTO movies(title) VALUES('%s')" % movie_dict['Title']
    with db:
        cursor = db.cursor()
        cursor.execute(query)
        print movie_dict['Title'] + ' was added to Theater Queue'
        
    # disconnect from server
    if db:
        db.close()
    
else:
    for row in rows:
        if movie_num == row[0]:
            show_query = "SELECT * FROM showtimes WHERE title = '%s'" % row[1]
            with db:
                cursor = db.cursor()
                cursor.execute(show_query)
                show_row = cursor.fetchone()
                print 'Date: ',
                print show_row[2]
                print 'Time: ',
                print show_row[3]
                
    # disconnect from server
    if db:
        db.close()