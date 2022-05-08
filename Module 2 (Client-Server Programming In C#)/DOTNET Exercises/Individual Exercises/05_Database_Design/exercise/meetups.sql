/* Deployment script for MovieDB */
USE master;
GO

IF DB_ID('MeetUps') IS NOT NULL
BEGIN
	ALTER DATABASE Meetups SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE MeetUps;
END
GO

CREATE DATABASE MeetUps;
GO

USE MeetUps
GO

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--CREATE MEMBER TABLE
CREATE TABLE [member] (
    member_number        INT             NOT NULL IDENTITY (1,1),
    last_name            NVARCHAR (200)  NOT NULL,
	first_name           NVARCHAR (200)  NOT NULL,
	email_address        NVARCHAR (200)  NOT NULL,
	phone_number         NVARCHAR (20)   NULL,
	date_of_birth        DATE			 NOT NULL,
	reminder_email_flag  BIT             NOT NULL,  
	--event_number         INT             NULL,
	--group_number         INT             NULL,
	CONSTRAINT [PK_member] PRIMARY KEY (member_number),
);

--CREATE INTEREST GROUP TABLE
CREATE TABLE [interest_group] (
    group_number		INT              NOT NULL IDENTITY (1,1),
    group_name			NVARCHAR (200)   NOT NULL,
	CONSTRAINT [UQ_group_name] UNIQUE (group_name),
	CONSTRAINT [PK_interest_group] PRIMARY KEY (group_number)
);

--CREATE EVENT TABLE
CREATE TABLE [event] (
    event_number          INT             NOT NULL IDENTITY (1,1),
    event_name            NVARCHAR (200)  NOT NULL,
	[description]         NVARCHAR (MAX)  NOT NULL,
	start_date_and_time   DATETIME        NOT NULL,
	duration              INT             NOT NULL,
	CONSTRAINT [chk_event] CHECK (duration>=30),
	CONSTRAINT [PK_event] PRIMARY KEY (event_number)
);

--CREATE MEMBER GROUP TABLE
CREATE TABLE [member_group] (
	member_number    INT   NOT NULL,
	group_number     INT   NOT NULL,
	CONSTRAINT [PK_member_groupnum_MTM] PRIMARY KEY (member_number),
	CONSTRAINT [FK_member_groupnum_MTM] FOREIGN KEY (group_number) REFERENCES [interest_group] (group_number),
	CONSTRAINT [FK_member_group_MTM] FOREIGN KEY (member_number) REFERENCES [member] (member_number)
);

--CREATE MEMBER EVENT TABLE
CREATE TABLE [member_event] (
	member_number    INT   NOT NULL,
	event_number     INT   NOT NULL,
	CONSTRAINT [PK_member_eventnum_MTM] PRIMARY KEY (member_number),
	CONSTRAINT [FK_member_eventnum_MTM] FOREIGN KEY (event_number) REFERENCES [event] (event_number),
	CONSTRAINT [FK_member_event_MTM] FOREIGN KEY (member_number) REFERENCES [member] (member_number)	
);

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--PUSH DATA TO MEMBER TABLE
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Shatokhin', 'Mikhail', 'shatokhingti@gmail.com', '4402236229','1996/07/16',1);
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Updyke', 'John', 'updyke@gmail.com', '4402264624','1996/02/11',1);
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Fulton', 'John', 'fulton@gmail.com', '4404563242','1976/09/27',1);
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Robbie', 'Margaret', 'duchess@gmail.com', '4402354567','1973/10/12',1);
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Aniston', 'Jennifer', 'jenan@gmail.com', '4402314523','1974/12/26',0);
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Hadid', 'Bella', 'bellz@gmail.com', '4402789657','1971/01/12',0);
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Upton', 'Kate', 'kateup@gmail.com', '4406757876','1969/03/05',0);
INSERT INTO member (last_name, first_name, email_address,phone_number,date_of_birth,reminder_email_flag)
 VALUES ('Jolie', 'Angelina', 'Angy@gmail.com', '4402234232','1980/05/01',1);

--PUSH DATA TO INTEREST GROUP TABLE
INSERT INTO interest_group (group_name)
  VALUES ('Hard Rock');
INSERT INTO interest_group (group_name)
  VALUES ('Classical Rock');
INSERT INTO interest_group (group_name)
  VALUES ('Smooth Jazz');

--PUSH DATA TO EVENT TABLE
INSERT INTO [event] (event_name,[description],start_date_and_time,duration)
  VALUES ('Metallica','Come join the moshpit','2022/01/01 03:00:00',120);
INSERT INTO [event] (event_name,[description],start_date_and_time,duration)
  VALUES ('Led Zepplin','The Zepplin has landed','2022/02/10 03:00:00',60);
INSERT INTO [event] (event_name,[description],start_date_and_time,duration)
  VALUES ('Bon Jovi','Living on a concert ticket','2022/03/20 03:00:00',180);
INSERT INTO [event] (event_name,[description],start_date_and_time,duration)
  VALUES ('ACDC','We dont know the order of the alphabet','2022/04/05 03:00:00',180);

--PUSH DATA TO MEMBER GROUP TABLE
INSERT INTO member_group (member_number, group_number)
  VALUES (1,1);
INSERT INTO member_group (member_number,group_number)
  VALUES (2,1);
INSERT INTO member_group (member_number,group_number)
  VALUES (3,2);
INSERT INTO member_group (member_number,group_number)
  VALUES (4,2);
INSERT INTO member_group (member_number,group_number)
  VALUES (5,3);
INSERT INTO member_group (member_number,group_number)
  VALUES (6,3);
INSERT INTO member_group (member_number,group_number)
  VALUES (7,1);
INSERT INTO member_group (member_number,group_number)
  VALUES (8,2);

--PUSH DATA TO MEMBER EVENT TABLE
INSERT INTO member_event (member_number,event_number)
  VALUES (1,1);
INSERT INTO member_event (member_number,event_number)
  VALUES (2,1);
INSERT INTO member_event (member_number,event_number)
  VALUES (3,2);
INSERT INTO member_event (member_number,event_number)
  VALUES (4,2);
INSERT INTO member_event (member_number,event_number)
  VALUES (5,3);
INSERT INTO member_event (member_number,event_number)
  VALUES (6,3);
INSERT INTO member_event (member_number,event_number)
  VALUES (7,4);
INSERT INTO member_event (member_number,event_number)
  VALUES (8,4);
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
