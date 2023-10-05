# TermiteSVCToolsV0.1.0

This program will be a CLI ran program that will have several options to calculate information, log customer information / callback as a **technician**, and hopefully a few other *useful* tools.
* `TermiteSVCLogger` - Logging customer information (class/super)
* * `TermiteSVCEstimator?` - Calculating job pricing, product usage, sqft, and linear footage with a price breakdown (class)
* `TermiteSVCCreator` - Creating customer entries, (derived/child of Logger)
* `TermiteSVCFollowUp` - Some added information to help techs find problems (derived/child of Logger)
* 
- Chemical usage estimate for a job (ounces + total gallons needed).
- Basic customer information logging for individual technicians to personalize the treatment process / RT process. This will include Phone number, address, names, and service notes that will actually be saved and useable by technicians. You can also put in a reminder for 45 day checkups, 90 day checkups, or 6 month checkups(flexpack installations only). This feature helps technicians to manage customer base personally while achieving customer satisfaction in the form of great communication.
- Area calculator which will be performed in the background to give a 'statistics' view later. This is made possible by EnterMeasurements() - where you can start at one section of a house and follow around with linear footage per section.
- Average price point based off linear footage of home, with all treatment types from bait job, PP, PP+Bait, Conventional.
- Additional support for bait installations / drywood (specialty treatments)
- Possible API support for database connection / simply using JSON To store and retrieve data.
- Possible integration of storing customer graphs with dated retrieval for sales inspectors as requested by a inspector.
