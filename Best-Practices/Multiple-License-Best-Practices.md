#Best Practices for Maintaining Multiple License Keys

[[_TOC_]]

##About

If your company re-distributes individual copies of your product to many different clients and your business model requires a license key for each new client, then it will be necessary to be able to maintain a solution for easily changing license keys without having to re-deploy to a client site. Many different strategies exist for this as Izenda embeds directly into your code, so you have complete control over how you maintain this information. We will go over a few popular options.

##Maintaining a database

Since the license keys are string values, they can be easily encrypted and stored in a database and distributed through a generalized implementation within the global.asax of every deployment you have to perform. The value will then need to be decrypted before its value is assigned. This can be done using the simple SQL client library or your primary database driver methods. Alternately, you can utilize the AdHoc methods for working with datasets directly to speed up the process.

##web.config

Another way of maintaining multiple license keys is to use encrypted string values in the AppSettings section of the web.config. This will require less database operations but is not maintainable remotely and will at least require replacing the file on every server that needs to be updated. Again, the value will need to be decrypted in the global.asax before assigning the value of the license key.

Ultimately, the strategy that is preferable to you will depend on your unique business practices and needs. 