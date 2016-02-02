BEGIN TRANSACTION;
DROP TABLE IF EXISTS "Sections";
CREATE TABLE "Sections" ("Id" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE , "Name" VARCHAR NOT NULL , "Order" INTEGER NOT NULL , "Content" VARCHAR NOT NULL , "Image" VARCHAR, "LayoutId" INTEGER NOT NULL );
INSERT INTO "Sections" VALUES(1,'Test',0,'<h2>Lorem ipsum dolor sit amet</h2>

<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In odio nisi, ultricies eu mauris et, hendrerit rutrum enim. Sed consectetur in justo vitae mollis.</p>
<p>Aliquam vestibulum tellus ac dui volutpat sollicitudin. Suspendisse vel augue eget augue vulputate viverra venenatis faucibus lacus. Integer tempus gravida lacus, nec semper massa consectetur a.</p>
<p>Nam quis lectus ante. Cras quis enim eget quam tincidunt dignissim. Sed arcu nunc, tempor et elementum nec, iaculis in arcu. Fusce dictum venenatis ornare. Donec pellentesque purus quis lacinia vulputate.</p>
<p>In at nibh in est rutrum vehicula. Morbi ullamcorper at nunc a tempus. Sed iaculis ut mi in volutpat. Nunc eu dui et lacus suscipit lobortis.</p>',NULL,1);
INSERT INTO "Sections" VALUES(2,'Test',0,'<h2>Lorem ipsum dolor sit amet</h2>

<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In odio nisi, ultricies eu mauris et, hendrerit rutrum enim. Sed consectetur in justo vitae mollis.</p>
<p>Aliquam vestibulum tellus ac dui volutpat sollicitudin. Suspendisse vel augue eget augue vulputate viverra venenatis faucibus lacus. Integer tempus gravida lacus, nec semper massa consectetur a.</p>
<p>Nam quis lectus ante. Cras quis enim eget quam tincidunt dignissim. Sed arcu nunc, tempor et elementum nec, iaculis in arcu. Fusce dictum venenatis ornare. Donec pellentesque purus quis lacinia vulputate.</p>
<p>In at nibh in est rutrum vehicula. Morbi ullamcorper at nunc a tempus. Sed iaculis ut mi in volutpat. Nunc eu dui et lacus suscipit lobortis.</p>','dummy.jpg',2);
INSERT INTO "Sections" VALUES(3,'Test',0,'<h2>Lorem ipsum dolor sit amet</h2>

<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In odio nisi, ultricies eu mauris et, hendrerit rutrum enim. Sed consectetur in justo vitae mollis.</p>
<p>Aliquam vestibulum tellus ac dui volutpat sollicitudin. Suspendisse vel augue eget augue vulputate viverra venenatis faucibus lacus. Integer tempus gravida lacus, nec semper massa consectetur a.</p>
<p>Nam quis lectus ante. Cras quis enim eget quam tincidunt dignissim. Sed arcu nunc, tempor et elementum nec, iaculis in arcu. Fusce dictum venenatis ornare. Donec pellentesque purus quis lacinia vulputate.</p>
<p>In at nibh in est rutrum vehicula. Morbi ullamcorper at nunc a tempus. Sed iaculis ut mi in volutpat. Nunc eu dui et lacus suscipit lobortis.</p>',NULL,1);
INSERT INTO "Sections" VALUES(4,'Test',0,'<h2>Lorem ipsum dolor sit amet</h2>

<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In odio nisi, ultricies eu mauris et, hendrerit rutrum enim. Sed consectetur in justo vitae mollis.</p>
<p>Aliquam vestibulum tellus ac dui volutpat sollicitudin. Suspendisse vel augue eget augue vulputate viverra venenatis faucibus lacus. Integer tempus gravida lacus, nec semper massa consectetur a.</p>
<p>Nam quis lectus ante. Cras quis enim eget quam tincidunt dignissim. Sed arcu nunc, tempor et elementum nec, iaculis in arcu. Fusce dictum venenatis ornare. Donec pellentesque purus quis lacinia vulputate.</p>
<p>In at nibh in est rutrum vehicula. Morbi ullamcorper at nunc a tempus. Sed iaculis ut mi in volutpat. Nunc eu dui et lacus suscipit lobortis.</p>','dummy.jpg',2);
INSERT INTO "Sections" VALUES(5,'Test',0,'<h2>Lorem ipsum dolor sit amet</h2>

<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In odio nisi, ultricies eu mauris et, hendrerit rutrum enim. Sed consectetur in justo vitae mollis.</p>
<p>Aliquam vestibulum tellus ac dui volutpat sollicitudin. Suspendisse vel augue eget augue vulputate viverra venenatis faucibus lacus. Integer tempus gravida lacus, nec semper massa consectetur a.</p>
<p>Nam quis lectus ante. Cras quis enim eget quam tincidunt dignissim. Sed arcu nunc, tempor et elementum nec, iaculis in arcu. Fusce dictum venenatis ornare. Donec pellentesque purus quis lacinia vulputate.</p>
<p>In at nibh in est rutrum vehicula. Morbi ullamcorper at nunc a tempus. Sed iaculis ut mi in volutpat. Nunc eu dui et lacus suscipit lobortis.</p>',NULL,1);
INSERT INTO "Sections" VALUES(6,'Test',0,'<h2>Lorem ipsum dolor sit amet</h2>

<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In odio nisi, ultricies eu mauris et, hendrerit rutrum enim. Sed consectetur in justo vitae mollis.</p>
<p>Aliquam vestibulum tellus ac dui volutpat sollicitudin. Suspendisse vel augue eget augue vulputate viverra venenatis faucibus lacus. Integer tempus gravida lacus, nec semper massa consectetur a.</p>
<p>Nam quis lectus ante. Cras quis enim eget quam tincidunt dignissim. Sed arcu nunc, tempor et elementum nec, iaculis in arcu. Fusce dictum venenatis ornare. Donec pellentesque purus quis lacinia vulputate.</p>
<p>In at nibh in est rutrum vehicula. Morbi ullamcorper at nunc a tempus. Sed iaculis ut mi in volutpat. Nunc eu dui et lacus suscipit lobortis.</p>','dummy.jpg',2);
COMMIT;
