# Beerio

## EF + Scaffolded MVC

In this branch I explored the idea of EF with MVC scaffolding using Razor. 
I took the general data design idea that I had tried to flush 
out in the database-less version, and attempted to implement it with Razor
pages. The goal was to flush out an end-to-end proof of concept in a quick way. 
Having spent 2 years working on a large legacy code base that was a mixture 
of webforms, MVC, and large database, I underestimated the time it would take 
to do an initial setup. As well as the time get up to speed with Razor. 
Consequently I ran out of time before I could get things where I wanted.

I still like the idea that a Recipe is built with a list of RecipeIngredient
items.  Where a RecipeIngredient has an Ingredient ID and a quantity.
Getting the mapping from a Recipe, to a RecipeIngredient, to an Ingredient so I
could display the Ingredient name on a page, is where I ran out of time.

Thinking more about that mapping is where I would like to spend more time.
