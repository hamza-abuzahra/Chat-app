drop database if exists EmployeeInfo;

create database if not exists EmployeeInfo;

use EmployeeInfo;

create table Info(
    Eid int primary key, 
    Ename varchar(20),
    Esurname varchar(20), 
    Eemail varchar(45),
    Epassword varchar(20), 
    ElastAcess Time
);


insert into Info values (1, "Hamza", "Abuzahra", "hamza.abuzahra@bilgiedu.net", "1", "");
insert into Info values (2, "Mohammad", "Hamed", "abdul.hamed@bilgiedu.net", "", "");
insert into Info values (3, "Omar", "Al-Shareef", "al.alshareef@bilgiedu.net", "2", "");
insert into Info values (4, "Zeynep", "Yilmaz", "sena.yilmaz03@bilgiedu.net", "", "");
insert into Info values (5, "Ali", "Allouche", "ali.allouche@bilgiedu.net", "", "");
insert into Info values (6, "Mohammed", "Nasseir", "ghassan.nasseir@bilgiedu.net", "", "");
insert into Info values (7, "Maximilian", "Arat", "cevdet.arat@bilgiedu.net", "", "");
insert into Info values (8, "Emran", "Khammash", "di.sa@bilgiedu.net", "", "");
insert into Info values (9, "Maged", "Al-Ward", "abdullah.alward@bilgiedu.net", "", "");
insert into Info values (10, "Murat", "Oguz", "murat.oguz@bilgi.edu.tr", "", "");
insert into Info values (11, "everyone", "everyone", "everyone", "", "");
insert into Info values (12, "super", "user", "superuser", "root", "");

