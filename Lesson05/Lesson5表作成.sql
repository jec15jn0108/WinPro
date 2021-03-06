CREATE TABLE bunrui
(bunruino int NOT NULL primary key,
 bunruiname nvarchar(50) NOT NULL 
)

insert into bunrui values(1,'ÆdEz[pi')
insert into bunrui values(2,'AV@í')
insert into bunrui values(3,'p\REüÓ@í')

CREATE TABLE syohin
(syohincode char(5) NOT NULL primary key,
 syohinname nvarchar(50) NOT NULL ,
 price int NOT NULL ,
 bunruino int references bunrui(bunruino)
)
 
insert into syohin values('A0001','â É 110L',21700,1)
insert into syohin values('A0002','h®ôó£@ 7kg',157600,1)
insert into syohin values('A0003','TCN|@(¬^)',18000,1)
insert into syohin values('A0004','ChI[uW',20300,1)
insert into syohin values('A0005','GAR(ÈGl^Cv) 6ô',59400,1)
insert into syohin values('A0006','}bT[W`FA',328000,1)
insert into syohin values('B0001','40V^ t»er',56000,2)
insert into syohin values('B0002','u[CEDVDR[_[',45800,2)
insert into syohin values('B0003','CXwbhz',26250,2)
insert into syohin values('B0004','fW^ vWFN^[',154800,2)
insert into syohin values('C0001','m[gPC 11.6^ Cht»',149800,3)
insert into syohin values('C0002','t»êÌ^fXNgbvp\R',97800,3)
insert into syohin values('C0003','CNWFbg¡@',16800,3)
insert into syohin values('C0004','Ot¯n[hfBXN 2TB',11800,3)


CREATE TABLE syain
(SyainNo char(4) NOT NULL primary key,
 SyainName nvarchar(50) NOT NULL ,
 NyusyaDate date NOT NULL ,
 Zaisyoku bit NOT NULL
)
 
insert into syain values('1001','àc@MT','1978-04-01','True')
insert into syain values('1002','â{@MK','1978-05-10','True')
insert into syain values('1003','ä@Ç¹','1979-04-01','True')
insert into syain values('1004','´@å','1979-04-01','False')
insert into syain values('1005','Øº@rF','1980/4/1','True')
insert into syain values('1006','·Jì@i','1981/4/1','True')
insert into syain values('1007','Îä@T','1981/4/1','True')
insert into syain values('1008','¬@O','1982/4/1','True')
insert into syain values('1009','ª{@','1983/4/1','True')
insert into syain values('1010','«§@ër','1984/4/1','True')
insert into syain values('1011','àq@«ê','1985/4/1','True')
insert into syain values('1012','{ò@qY','1986/4/1','True')
insert into syain values('1013','öc@T¾','1986/4/1','True')
insert into syain values('1014','R{@qç','1987/4/1','True')
insert into syain values('1015','Øà@Bç','1988/4/1','True')
insert into syain values('1016','¡@É','1990/4/1','True')
insert into syain values('1017','¡ì@Ã','1991/4/1','True')
insert into syain values('1018','Öû@»','1993/4/1','True')
insert into syain values('1019','àä@xî','1994/4/1','True')
insert into syain values('1020','O´@','1996/4/1','True')
insert into syain values('1021','Ã®@L÷','1998/4/1','True')
insert into syain values('1022','²ì@KG','2000/4/1','True')
insert into syain values('1023','âä@ãÄ','2000/4/1','True')
insert into syain values('1024','ªc@º','2001/4/1','False')
insert into syain values('1025','Oä@éD','2002/4/1','True')
insert into syain values('1026','¬r@Tq','2003/4/1','True')
insert into syain values('1027','½ì@','2004/4/1','True')
insert into syain values('1028','¬àV@³l','2005/4/1','True')
insert into syain values('1029','´ì@¾q','2006/4/1','True')
insert into syain values('1030','Îä@²÷','2007/4/1','True')
insert into syain values('1031','´c@_i','2009/4/1','True')
insert into syain values('1032','×ì@T¾','2010/4/1','True')
insert into syain values('1033','åà@Yå','2011/4/1','False')
insert into syain values('1034','~c@MO','2012/4/1','True')
insert into syain values('1035','¼@Äó','2013/4/1','True')
insert into syain values('1036','äã@T','2013/4/1','True')

CREATE TABLE shikaku
(shikakuno int NOT NULL Primary key,
 shikakuname nvarchar(50),
 teate int
)

insert into shikaku values(1,'ITpX|[g',2000)
insert into shikaku values(2,'î{îñZpÒ',5000)
insert into shikaku values(3,'pîñZpÒ',8000)
insert into shikaku values(4,'f[^x[XXyVXg',10000)
insert into shikaku values(5,'lbg[NXyVXg',10000)

CREATE TABLE syutoku
(syainno char(4) NOT NULL references syain(syainno),
 sikakuno int NOT NULL references shikaku(shikakuno), 
 syutokudate date,
 constraint syutoku_pk primary key(syainno,sikakuno)
)
 
insert into syutoku values('1002',4,'1998/7/28')
insert into syutoku values('1003',4,'1997/7/30')
insert into syutoku values('1003',5,'1998/12/22')
insert into syutoku values('1005',3,'2000/7/25')
insert into syutoku values('1006',1,'2012/1/20')
insert into syutoku values('1007',2,'2002/11/18')
insert into syutoku values('1009',2,'2002/11/18')
insert into syutoku values('1010',3,'2000/7/25')
insert into syutoku values('1010',4,'2002/7/22')
insert into syutoku values('1010',5,'2006/12/21')
insert into syutoku values('1013',1,'2012/8/10')
insert into syutoku values('1014',2,'2005/6/25')
insert into syutoku values('1016',2,'2004/11/19')
insert into syutoku values('1016',3,'2006/12/21')
insert into syutoku values('1018',1,'2012/10/20')
insert into syutoku values('1019',1,'2012/1/30')
insert into syutoku values('1020',2,'2002/11/18')
insert into syutoku values('1022',2,'2002/11/18')
insert into syutoku values('1023',3,'2002/12/20')
insert into syutoku values('1023',5,'2005/12/18')
insert into syutoku values('1025',1,'2013/2/15')
insert into syutoku values('1026',1,'2013/3/1')
insert into syutoku values('1026',2,'2012/11/18')
insert into syutoku values('1026',3,'2013/6/21')
insert into syutoku values('1029',2,'2007/11/20')
insert into syutoku values('1029',3,'2010/6/15')
insert into syutoku values('1031',2,'2009/11/23')
insert into syutoku values('1032',2,'2010/5/20')
insert into syutoku values('1032',3,'2011/12/20')
insert into syutoku values('1034',1,'2012/4/30')