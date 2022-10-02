                                     --- DBS PROJECT---
--                                LOST VEHCILE CLAIM COMPANY
--  Members   
--        1) Jabeen-e-Zahra Hamdani  -- 200901047
--        2) Muhammad Ahmad Siddique -- 200901077


CREATE DATABASE LLLOST_VEHICLESSSS
use LLLOST_VEHICLESSSS

CREATE TABLE CLIENT(NAME_ VARCHAR(100) NOT NULL,ADDRESS_ VARCHAR(100) NOT NULL,CITY VARCHAR(25) NOT NULL,
CNIC varchar(50) NOT NULL Primary key,CELL_NO varchar(50) NOT NULL)


CREATE TABLE Company(COMP_NAME VARCHAR(100) NOT NULL foreign key references new_record(car_company), MODEL VARCHAR(50) NOT NULL ,
CHASSIS VARCHAR(100) NOT NULL foreign key references RECORD(chasis_no),
YEAR_PURCHASE varchar(50) NOT NULL,OWNED_BY VARCHAR(100) NOT NULL,Cnic_client varchar(50) NOT NULL foreign key references CLIENT (CNIC))


CREATE TABLE INCIDENT(INC_DATE VARCHAR(100) NOT NULL,INC_ADDRESS VARCHAR(100) NOT NULL, FIR_DATE VARCHAR(100) NOT NULL,
NAME_STATION VARCHAR(100), FIR_NO VARCHAR(100) NOT NULL,CNIC_client varchar(50) foreign key references CLIENT (CNIC))


Create table RECORD (Model_ varchar(100), chasis_no varchar(100) primary key, dateofRecovery varchar(100));

Create table new_record ( Car_company varchar(100) Primary key);




---INERJOINT search----

sp_help CLIENT
Sp_help Company
sp_help INCIDENT

SELECT *FROM CLIENT,Company,INCIDENT;
SELECT *FROM Company
SELECT *FROM INCIDENT
Select * from new_record


drop table RECORD
