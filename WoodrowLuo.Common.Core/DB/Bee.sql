------------�������������б�---
create table Bee
(
   Id int primary key identity(1,1),
   Name varchar(50),
   Category int ,
   BeeWeight int,
   Color varchar(20),
   Number int,
   SendUser varchar(50),
   SendPhone varchar(20),
   SendAddress varchar(200),
   SendTime datetime,
   ReceviedUser varchar(50),
  Receviedhone varchar(20),
  ReceviedAddress varchar(200),
  ReceviedTime datetime,
  SaleTime datetime,
  BeeStatus int
   )

   -----------��������------
   create table Category
   (
      ID int primary key identity,
	  Name varchar(50)
   )

   ----��������---
   insert into Category(Name)
   select '�ٻ���'union
   select '������'union
   select 'С�ݷ�'union
   select '����'union
   select '����'union
   select '������'union
   select '������'union
   select '�����'