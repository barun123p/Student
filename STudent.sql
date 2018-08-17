CREATE DATABASE STUDENT

CREATE TABLE STUDENTINFO
(
StudentId int NOT NULL ,
FIRSTNAME VARCHAR(50) NOT NULL ,
LASTNAME VARCHAR(50) NOT NULL,
PRIMARY KEY(StudentId)
);

CREATE TABLE COURSE
(
CourseId int NOT NULL ,
CourseName VARCHAR(50) NOT NULL ,
PRIMARY KEY(CourseId)
);

CREATE TABLE ENROLLMENT
(

ENROLLMENTID int NOT NULL ,
CourseId int NOT NULL ,
StudentId int NOT NULL ,
ENROLLEDFROM DATE NOT NULL ,
ENROLLEDTO DATE NOT NULL,
FOREIGN KEY(CourseId) REFERENCES COURSE(CourseId),
FOREIGN KEY(StudentId) REFERENCES STUDENT(StudentId)
);

CREATE TABLE STUDENTCONTACT
(
CITY VARCHAR(50) NOT NULL ,
STATENAME VARCHAR(15) NOT NULL ,
ZIPCODE int NOT NULL,
PHONENO int NOT NULL,
StudentId int NOT NULL ,
FOREIGN KEY(StudentId) REFERENCES STUDENTINFO(StudentId)
);

CREATE TABLE ENROLLMENT
(
StudentId int NOT NULL ,
ENROLLEDDATE DATE NOT NULL ,
ENDDATE DATE NOT NULL,
FOREIGN KEY(StudentId) REFERENCES STUDENTINFO(StudentId)
);


DROP TABLE STUDENT



create proc getstudentdata
as
begin
select * from STudentinfo
END
create proc getenrollment
as
begin
select * from ENROLLMENT
END


CREATE proc UPDATESTUDENT
(
@StudentId int,
@FIRSTNAME varchar(50),
@LASTNAME varchar(50)
)
as
begin
UPDATE STUDENTINFO SET  FIRSTNAME='@FIRSTNAME' ,LASTNAME='@LASTNAME'
where StudentId=@StudentId 
END

UPDATE STUDENTINFO SET  FIRSTNAME='Rajesh' ,LASTNAME='Hamal'
where StudentId=1 

Select * from STUDENTINFO;


CREATE proc DELETESTUDENT
(
@StudentId int
)
as
begin
SET NOCOUNT ON
DELETE FROM STUDENTINFO
where StudentId=@StudentId
END 




CREATE PROCEDURE dbo.sp_Students_DEL_byPK
       @student_id    INT        
AS 
BEGIN 
     SET NOCOUNT ON 

     DELETE 
     FROM   dbo.Students
     WHERE  
     student_id = @student_id

END
GO