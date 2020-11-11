CREATE TABLE stadiums (
	stadium_id int NOT NULL,
	stadiums_name varchar(50) NULL,
	city varchar(50) NULL,
	country varchar(50) NULL,
	PRIMARY KEY (stadium_id) );
CREATE TABLE teams (
	team_id int NOT NULL,
	name_of_team varchar(50) NULL,
	stadium_id int NULL REFERENCES Stadiums(stadium_id),
	date_of_creation date NULL,
	PRIMARY KEY (team_id) );
CREATE TABLE players (
	player_id int NOT NULL,
	name_of_player varchar(50) NULL,
	surname varchar(50) NULL,
	number int NULL,
	age int NULL,
	nationality varchar(50) NULL,
	team int NULL REFERENCES Teams(team_id),
	PRIMARY KEY (player_id));