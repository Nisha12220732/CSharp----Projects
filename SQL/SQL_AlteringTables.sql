use TopBrains_Question

Alter table ZIPCODE_INFO ADD STATE varchar(2);
sp_help ZIPCODE_INFO

Alter table INSTRUCTOR_INFO ADD STREET_ADDRESS varchar(50) default 'ADDRESS UNKNOWN';
Alter table INSTRUCTOR_INFO ADD ZIP_CODE varchar(5) default '91'
sp_help INSTRUCTOR_INFO

Alter table COURSE_INFO ADD COURSE_PREREQUISITE int;
Alter table COURSE_INFO ADD COURSE_NAME varchar default 'NewCourse';
sp_help COURSE_INFO

Alter table STUDENT_INFO ADD STREET_ADDRESS varchar(50) default 'I am a Student';
Alter table STUDENT_INFO ADD ZIP_CODER varchar(5) default '91';
sp_help STUDENT_INFO

ALTER table SECTION_INFO ADD
LOCATION varchar(50),
CAPACITY int;
sp_help SECTION_INFO;

Alter table ENROLLMENT_INFO ADD
ENROLLMENT_DATE Date;
sp_help ENROLLMENT_INFO;

Alter table GRADE_INFO ADD
NUMERIC_GRADE int;
sp_help GRADE_INFO;
