CREATE TABLE bunrui
(bunruino int NOT NULL primary key,
 bunruiname nvarchar(50) NOT NULL 
)

insert into bunrui values(1,'家電・ホーム用品')
insert into bunrui values(2,'AV機器')
insert into bunrui values(3,'パソコン・周辺機器')

CREATE TABLE syohin
(syohincode char(5) NOT NULL primary key,
 syohinname nvarchar(50) NOT NULL ,
 price int NOT NULL ,
 bunruino int references bunrui(bunruino)
)
 
insert into syohin values('A0001','冷蔵庫 110L',21700,1)
insert into syohin values('A0002','ドラム式洗濯乾燥機 7kg',157600,1)
insert into syohin values('A0003','サイクロン掃除機(小型)',18000,1)
insert into syohin values('A0004','ワイドオーブンレンジ',20300,1)
insert into syohin values('A0005','エアコン(省エネタイプ) 6畳',59400,1)
insert into syohin values('A0006','マッサージチェア',328000,1)
insert into syohin values('B0001','40V型 液晶テレビ',56000,2)
insert into syohin values('B0002','ブルーレイ・DVDレコーダー',45800,2)
insert into syohin values('B0003','ワイヤレスヘッドホン',26250,2)
insert into syohin values('B0004','デジタル プロジェクター',154800,2)
insert into syohin values('C0001','ノートPC 11.6型 ワイド液晶',149800,3)
insert into syohin values('C0002','液晶一体型デスクトップパソコン',97800,3)
insert into syohin values('C0003','インクジェット複合機',16800,3)
insert into syohin values('C0004','外付けハードディスク 2TB',11800,3)


CREATE TABLE syain
(SyainNo char(4) NOT NULL primary key,
 SyainName nvarchar(50) NOT NULL ,
 NyusyaDate date NOT NULL ,
 Zaisyoku bit NOT NULL
)
 
insert into syain values('1001','内田　貴裕','1978-04-01','True')
insert into syain values('1002','坂本　貴幸','1978-05-10','True')
insert into syain values('1003','堺　良昌','1979-04-01','True')
insert into syain values('1004','高橋　悟','1979-04-01','False')
insert into syain values('1005','木村　俊彦','1980/4/1','True')
insert into syain values('1006','長谷川　淑','1981/4/1','True')
insert into syain values('1007','石井　利典','1981/4/1','True')
insert into syain values('1008','小島　徹','1982/4/1','True')
insert into syain values('1009','岡本　翼','1983/4/1','True')
insert into syain values('1010','足立　雅俊','1984/4/1','True')
insert into syain values('1011','金子　賢一','1985/4/1','True')
insert into syain values('1012','宮沢　智郎','1986/4/1','True')
insert into syain values('1013','柳田　裕明','1986/4/1','True')
insert into syain values('1014','山本　智也','1987/4/1','True')
insert into syain values('1015','木内　達也','1988/4/1','True')
insert into syain values('1016','遠藤　遼','1990/4/1','True')
insert into syain values('1017','藤野　静香','1991/4/1','True')
insert into syain values('1018','関口　綾','1993/4/1','True')
insert into syain values('1019','金井　駿介','1994/4/1','True')
insert into syain values('1020','三原　結香','1996/4/1','True')
insert into syain values('1021','古屋　広樹','1998/4/1','True')
insert into syain values('1022','佐野　幸絵','2000/4/1','True')
insert into syain values('1023','坂井　翔','2000/4/1','True')
insert into syain values('1024','岡田　亮','2001/4/1','False')
insert into syain values('1025','三井　颯','2002/4/1','True')
insert into syain values('1026','小池　裕子','2003/4/1','True')
insert into syain values('1027','平野　豪','2004/4/1','True')
insert into syain values('1028','小澤　正人','2005/4/1','True')
insert into syain values('1029','清野　明子','2006/4/1','True')
insert into syain values('1030','石井　隆樹','2007/4/1','True')
insert into syain values('1031','原田　浩司','2009/4/1','True')
insert into syain values('1032','細野　裕太','2010/4/1','True')
insert into syain values('1033','大内　雄大','2011/4/1','False')
insert into syain values('1034','梅田　貴弘','2012/4/1','True')
insert into syain values('1035','西嶋　夏希','2013/4/1','True')
insert into syain values('1036','井上　裕','2013/4/1','True')

CREATE TABLE shikaku
(shikakuno int NOT NULL Primary key,
 shikakuname nvarchar(50),
 teate int
)

insert into shikaku values(1,'ITパスポート',2000)
insert into shikaku values(2,'基本情報技術者',5000)
insert into shikaku values(3,'応用情報技術者',8000)
insert into shikaku values(4,'データベーススペシャリスト',10000)
insert into shikaku values(5,'ネットワークスペシャリスト',10000)

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