# Beerio

## Beer Recipe

The goal of exercise was to explore creating a full stack app to manage beer recipes. 
I started by focusing on models and abstracted a database connection by 
having faux repo patterns for interactions. This way I was able to think about 
organization and unit tests. The master branch contains these intial design thoughts
and coding. I setup an MVC project, but the only directories of useful 
code from this phase are:

* Beerio/Beerio/Data
* Beerio/Beerio/Models
* Beerio.Tests/

These directories encapsulate intial design and tesing ideas. Learning about Razor
pages while creating the front end is the next phase.

## A tale of two branches

Later I sat down to wire in the database and flush out preliminary page views.
The EFMVC branch contains this work. Please look at EFMVC for end-to-end
implentation.
