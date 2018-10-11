# Beerio

## Backend/Server side 

For the beer recipe exercise, I choose the backend portion.  Knowing time
this week would be fragement, I started by just focusing thoughts on
models. I abstracted a database connection by having faux repo patterns interact
with models. This way I was able to chip away at the exercise by simply 
starting with organization and unit tests. The master branch contains these intial
design thoughts and work. I setup an MVC project, but the only directories of useful 
code from this phase are:

Beerio/Beerio/Data
Beerio/Beerio/Models
Beerio.Tests/

These directories encapuslate intial design and tesing ideas. 

## A tale of two branches

Later I sat down to wire in the database and flush out preliminary page views.
The EFMVC branch contains this work. Please look at EFMVC for end-to-end
implentation.

