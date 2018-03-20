insert into widgetsizes values (1, 1);

insert into widgetsizes values (2, 2);

insert into widgetsizes values (3, 3);

insert into widgetsizes values (4, 4);

insert into widgetsizes values (5, 5);

insert into widgetsizes values (6, 6);

insert into widgetclasses values(1, 'panel-primary');

insert into widgetclasses values(2, 'panel-warning');

insert into widgetclasses values(3, 'panel-danger');

insert into widgetclasses values(4, 'panel-simple-primary');

insert into widgetclasses values(5, 'panel-simple-warning');

insert into widgetclasses values(6, 'panel-simple-danger');

insert into qualificationtypes values(1, 'Master`s degree');

insert into qualificationtypes values(2, 'Bachelor`s degree with honours');

insert into qualificationtypes values(3, 'Non-honours bachelor`s degree');

insert into qualificationtypes values(4, 'Higher National Diploma');

insert into qualificationtypes values(5, 'Higher National Certificate`');


insert into titles values (1, 'Mr');

insert into titles values (2, 'Mrs');

insert into titles values (3, 'Ms');

insert into titles values (4, 'Miss');

insert into titles values (5, 'Dr');

insert into jobtypes values (1, 'Contract');

insert into jobtypes values (2, 'Permanent');

insert into jobtitles values (1,'Administrator');
insert into jobtitles values (2,'Project Manager');
insert into jobtitles values (3,'Support Worker');
insert into jobtitles values (4,'Business Development Manager');
insert into jobtitles values (5,'Assistant Manager');
insert into jobtitles values (6,'Labourer');
insert into jobtitles values (7,'Receptionist');
insert into jobtitles values (8,'Sales Executive');
insert into jobtitles values (9,'Account Manager');
insert into jobtitles values (10,'Quantity Surveyor');
insert into jobtitles values (11,'Care Assistant');
insert into jobtitles values (12,'Chef');
insert into jobtitles values (13,'Manager');
insert into jobtitles values (14,'Account Assistant');
insert into jobtitles values (15,'Customer Service Advisor');
insert into jobtitles values (16,'Registered Nurse');
insert into jobtitles values (17,'Electrician');
insert into jobtitles values (18,'Nurse');
insert into jobtitles values (19,'Teacher');
insert into jobtitles values (20,'Business Analyst');

insert into users values (1, 'SangsL','Olive1664', null);

insert into profiles values (1, 'Sangram', 'Lad', 'lad.sangram@gmail.com', '7890556161', 'apt 1','street','Birmingham',
'west mids', 'b1 4ha', 1, 1, 1);

update users set profileId =1 where id = 1;a

insert into qualifications values (1, 'B.E. Electricals', 'LT College of Engineering', STR_TO_DATE('1-01-2008', '%d-%m-%Y'),
STR_TO_DATE('1-08-2012', '%d-%m-%Y'), 1 , 2);

insert into qualifications values (2, 'B.E. Computers', 'DY College of Engineering', STR_TO_DATE('11-01-2005', '%d-%m-%Y'),
STR_TO_DATE('1-3-2001', '%d-%m-%Y'), 1 , 2);