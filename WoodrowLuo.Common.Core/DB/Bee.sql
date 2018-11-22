------------创建蜂蜜销售列表---
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

   -----------蜂蜜类型------
   create table Category
   (
      ID int primary key identity,
	  Name varchar(50)
   )

   ----插入数据---
   insert into Category(Name)
   select '百花蜜'union
   select '树洞蜜'union
   select '小草蜂'union
   select '岩蜜'union
   select '黑蜜'union
   select '土酸蜜'union
   select '树酸蜜'union
   select '树杈蜜'