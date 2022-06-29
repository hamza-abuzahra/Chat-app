-- drop database if exists EmployeeInfo;
create database if not exists EmployeeInfo;
use EmployeeInfo;
create table MessageLog(
    Senderid int,
    Recieverid int,
    MessageSent varchar(512),
    MessageTime DATETIME,
    primary key (Senderid, Recieverid)
);