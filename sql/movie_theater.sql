CREATE DATABASE gatsby_theater;
USE gatsby_theater;

CREATE TABLE movies
(
id int NOT NULL AUTO_INCREMENT,
title varchar(20),
genre varchar(100),
duration int,
PRIMARY KEY (id)
);

INSERT INTO movies(title,genre,duration)
VALUES ('Metropolis','Sci-Fi',153);

INSERT INTO movies(title,genre,duration)
VALUES ('Nosferatu','Horror',94);

INSERT INTO movies(title,genre,duration)
VALUES ('The Kid','Comedy',68);

INSERT INTO movies(title,genre,duration)
VALUES ('The Gold Rush','Adventure',95);

INSERT INTO movies(title,genre,duration)
VALUES ('The Circus','Comedy',71);

CREATE TABLE showtimes
(
id int NOT NULL AUTO_INCREMENT,
title varchar(20),	
movie_day date,
movie_time time,
PRIMARY KEY (id)
);

INSERT INTO showtimes(title,movie_day,movie_time)
VALUES ('Metropolis','2015-12-07',060504);

INSERT INTO showtimes(title,movie_day,movie_time)
VALUES ('The Kid','2015-15-07',090504);

CREATE TABLE concessions
(
id int,
item varchar(20),
price float,
quantity int
);

INSERT INTO concessions(id,item,price,quantity)
VALUES (1,'Chocolate',1.50,10);

CREATE TABLE promotions
(
id int,
promo varchar(30)
);

INSERT INTO promotions(id,promo)
VALUES (1,'labor day sale');
