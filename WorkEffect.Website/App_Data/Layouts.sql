BEGIN TRANSACTION;
DROP TABLE IF EXISTS "Layouts";
CREATE TABLE "Layouts" ("Id" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE , "Name" VARCHAR NOT NULL , "HtmlContainer" VARCHAR NOT NULL , "LayoutType" INTEGER NOT NULL  DEFAULT 0);
INSERT INTO "Layouts" VALUES(1,'TextOnly','<section id="{0}" class="container content-section text-center"><div class="row"><div class="col-lg-8 col-lg-offset-2">{1}</div></div></section>',0);
INSERT INTO "Layouts" VALUES(2,'WithImage','<section id="{0}" class="content-section text-center"><div class="download-section" style="background: url({1}) no-repeat center center scroll;"><div class="container"><div class="col-lg-8 col-lg-offset-2">{2}</div></div></div></section>',0);
COMMIT;
