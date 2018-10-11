# Beerio

## Backend/Server side 

For the beer recipe exercise, I choose the backend portion.  Knowing time
this week would be fragement, I started by just focusing thoughts on
models. I abstracted out database interactions by having the models interact with
faux repo patterns. This way I was able to start chip awary at the exercise by simply 
thinking about organization and unit tests. The master branch contains this intial
work. I setup an MVC project, but the only directories of useful code from this phase are:
Beerio/Beerio/Data
Beerio/Beerio/Models
Beerio.Tests/

These directories encapuslate intial design and tesing ideas. 

## A tale of two branches

Later I sat down to wire in the database and flush out preliminary page views.
The EFMVC branch contains this work. Please look at EFMVC for end-to-end
implentation.

