CREATE TABLE book
(Isbn varchar(20) NOT NULL primary key,
 title nvarchar(MAX) NOT NULL,
 writer nvarchar(50),
 publisher nvarchar(50)  
)

insert into book values('978-4000103435','アルゴリズムとデータ構造','石畑 清','岩波書店')
insert into book values('978-4053034656','1時間でハングルが読めるようになる本','チョ・ヒチョル','学研マーケティング')
insert into book values('978-4054052758','日本１００名城に行こう　公式スタンプ帳つき','日本城郭協会','学研パブリッシング')
insert into book values('978-4062764520','空飛ぶタイヤ(上)','池井戸 潤','講談社')
insert into book values('978-4062764537','空飛ぶタイヤ(下)','池井戸 潤','講談社') 
insert into book values('978-4101349220','きみの友だち','重松 清','新潮社')
insert into book values('978-4150795559','静寂の叫び〈上〉','ジェフリー ディーヴァー','早川書房')
insert into book values('978-4150795566','静寂の叫び〈下〉','ジェフリー ディーヴァー','早川書房')
insert into book values('978-4163763804','アップル帝国の正体','後藤 直義 森川 潤','文藝春秋')
insert into book values('978-4274068768','マスタリングTCP/IP 入門編','竹下 隆史他','オーム社')
insert into book values('978-4274202179','情報セキュリティ標準テキスト','情報セキュリティ標準テキスト編集委員会','オーム社')
insert into book values('978-4334927769','舟を編む','三浦 しをん','光文社')
insert into book values('978-4344420557','清須会議','三谷 幸喜','幻冬舎')
insert into book values('978-4478022214','統計学が最強の学問である','統計学が最強の学問である','ダイヤモンド社')
insert into book values('978-4526064883','太陽光発電システムの不具合事例ファイル―PVRessQ!からの現地調査報告','加藤 和彦','日刊工業新聞社')
insert into book values('978-4528017788','みるみる歌が上手くなる 魔法のボイストレーニング','後藤 友輔','日東書院本社')
insert into book values('978-4532168384','社長のテスト','山崎 将志','日本経済新聞出版社')
insert into book values('978-4774116303','かんたんプログラミング VisualBasic.NET 基礎編','川口 輝久','技術評論社')
insert into book values('978-4774153681','デザインの学校 これからはじめるPhotoshopの本','I&D 宮川 千春 木俣 カイ ロクナナワークショップ 監修','技術評論社')
insert into book values('978-4797327922','新版 明解C言語 入門編','柴田望洋','ソフトバンククリエイティブ')
insert into book values('978-4797368277','詳解 Objective-C 2.0','荻原 剛志','ソフトバンククリエイティブ')
insert into book values('978-4797369601','自分で作れる! おしゃれなWebサイト','久松 慎一','ソフトバンククリエイティブ')
insert into book values('978-4797372960','スラスラわかるHTML&CSSのきほん','狩野 祐東','ソフトバンククリエイティブ')
insert into book values('978-4798024035','わかりやすいJava入門編','川場 隆','秀和システム')
insert into book values('978-4798035352','ポケット図解 最新消費税がよーくわかる本','奥村 佳史','秀和システム')
insert into book values('978-4798122083','Excel VBA 逆引き辞典パーフェクト','田中 亨','翔泳社')
insert into book values('978-4798124704','達人に学ぶDB設計 徹底指南書 初級者で終わりたくないあなたへ','ミック','翔泳社')
insert into book values('978-4798126258','HTTPの教科書','上野 宣','翔泳社')
insert into book values('978-4798128023','プログラマのためのSQL','ジョー・セルコ Joe Celko','翔泳社')
insert into book values('978-4809410000','サッカー「観戦力」が高まる','清水 英斗','東邦出版')
insert into book values('978-4819112192','国民の憲法','産経新聞社','産経新聞出版')
insert into book values('978-4822285081','3週間完全マスター ネットワークスペシャリスト','Gene 小林洋之 松田千賀','日経BP社')
insert into book values('978-4844330868','スッキリわかるJava入門','中山 清喬 国本 大悟','インプレスジャパン')
insert into book values('978-4844331278','本格アプリを作ろう！ Androidプログラミングレシピ','Dave Smith他','インプレスジャパン')
insert into book values('978-4844998853','10日で合格るぞ!日商簿記3級 光速マスターテキスト','東京リーガルマインド LEC総合研究所 日商簿記試験部','東京リーガルマインド')
insert into book values('978-4861996115','死ぬまでに行きたい! 世界の絶景','詩歩','三才ブックス')
insert into book values('978-4877710781','仕事は楽しいかね?','デイル ドーテン','きこ書房')
insert into book values('978-4887244528','ボトムアップ式 映画英語のリスニング 新装版―NewYork Detective Story','森田 勝之','ディーエイチシー')

CREATE TABLE gakusei
(gakuno char(8) NOT NULL primary key,
 gakuname nvarchar(50) NOT NULL ,
 mailaddress varchar(MAX) NOT NULL ,
 zaiseki bit NOT NULL
)

insert into gakusei values('12JZ0001','金子　賢一','11jz0001@jec.ac.jp','True')
insert into gakusei values('12JZ0002','宮沢　智郎','11jz0002@jec.ac.jp','True')
insert into gakusei values('12JZ0003','柳田　裕明','11jz0003@jec.ac.jp','True')
insert into gakusei values('12JZ0004','山本　智也','11jz0004@jec.ac.jp','True')
insert into gakusei values('12JZ0005','木内　達也','11jz0005@jec.ac.jp','True')
insert into gakusei values('13JN0001','長谷川　淑','12jn0001@jec.ac.jp','True')
insert into gakusei values('13JN0002','石井　利典','12jn0002@jec.ac.jp','True')
insert into gakusei values('13JN0003','小島　徹','12jn0003@jec.ac.jp','True')
insert into gakusei values('13JN0004','岡本　翼','12jn0004@jec.ac.jp','True')
insert into gakusei values('13JN0005','足立　雅俊','12jn0005@jec.ac.jp','True')
insert into gakusei values('13JZ0001','遠藤　遼','12jz0001@jec.ac.jp','True')
insert into gakusei values('13JZ0002','藤野　静香','12jz0002@jec.ac.jp','True')
insert into gakusei values('13JZ0003','関口　綾','12jz0003@jec.ac.jp','True')
insert into gakusei values('13JZ0004','金井　駿介','12jz0004@jec.ac.jp','True')
insert into gakusei values('13JZ0005','三原　結香','12jz0005@jec.ac.jp','True')
insert into gakusei values('14JN0001','内田　貴裕','13jn0001@jec.ac.jp','True')
insert into gakusei values('14JN0002','坂本　貴幸','13jn0002@jec.ac.jp','True')
insert into gakusei values('14JN0003','堺　良昌','13jn0003@jec.ac.jp','True')
insert into gakusei values('14JN0004','高橋　悟','13jn0004@jec.ac.jp','True')
insert into gakusei values('14JN0005','木村　俊彦','13jn0005@jec.ac.jp','True')
insert into gakusei values('14JZ0001','古屋　広樹','13jz0001@jec.ac.jp','True')
insert into gakusei values('14JZ0002','佐野　幸絵','13jz0002@jec.ac.jp','True')
insert into gakusei values('14JZ0003','坂井　翔','13jz0003@jec.ac.jp','True')
insert into gakusei values('14JZ0004','岡田　亮','13jz0004@jec.ac.jp','True')
insert into gakusei values('14JZ0005','三井　颯','13jz0005@jec.ac.jp','True')

CREATE TABLE kashidashi
(kashino int NOT NULL primary key,
 gakuno char(8) NOT NULL references gakusei(gakuno), 
 isbn varchar(20) NOT NULL references book(isbn),
 kashidate date NOT NULL,
 yoteidate date NOT NULL,
 hendate date
)

insert into kashidashi values(1,'14JN0004','978-4798024035','2014-11-06','2014-11-19','')

CREATE TABLE yoyaku
(yoyakuno int NOT NULL primary key,
 isbn varchar(20) NOT NULL references book(isbn),
 gakuno char(8) NOT NULL references gakusei(gakuno), 
 yoyakudate datetime NOT NULL
)

