# Travel API 

#### By E. Luckie ☀️

#### Build an API that allows users to `GET` and `POST` reviews about various travel destinations around the world.

## Technologies Used

* C#
* .NET 7.0
* API
* Postman
* MySQL Workbench
* Swagger
* Markdown
* Git

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory. called "TravelApi".
3. Within the production directory "TravelApi", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `[YOUR-USERNAME-HERE]` and `[YOUR-PASSWORD-HERE]` with your own credentials for MySQL. 

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

5. Within the production directory "TravelApi", run `dotnet run` in the command line to start the project in development mode.

6. While the project is running, you are free to make API calls to the given endpoints with or without the optional parameters and have information returned

### Endpoints

```
GET http://localhost:5000/api/places/
GET http://localhost:5000/api/places/{id}
POST http://localhost:5000/api/places/
PUT http://localhost:5000/api/places/{id}
DELETE http://localhost:5000/api/places/{id}
```

### Optional Parameters
| Parameter | Type | Required | Description |
| --------- | ---- | -------- | ----------- |
| rating | number | no | returns all places with a matching rating |
| minimumRating | number | no | returns all places with a rating matching or greater than the specified value |
| rec | boolean (true) | no | returns all "recommended" places (with a rating of 4-5) |
| city | string | no | returns all places with a matching city name | 
| state | string | no | returns all places with a matching state name |
| country | string | no | returns all places with a matching country name |


#### Example Queries
* The following query will return all places with a rating value of 3:

```GET http://localhost:5000/api/places?rating=3```


* The following query will return all places with a minimum rating of 2:

```GET http://localhost:5000/api/places?minimumRating=2```


* The following query will return all places with a rating of 4-5:

```GET http://localhost:5000/api/places?rec=true```


* The following query will return all places labeled "Cleveland"

``` GET http://localhost:5000/api/places?city=San Francisco```


* The following query will return all places in "Arizona"

``` GET http://localhost:5000/api/places?state=Arizona```


* The following query will return all places in the "USA"

``` GET http://localhost:5000/api/places?country=USA```


* It's possible to include multiple query strings by separating them with an `&`:

```GET http://localhost:5000/api/places?state=California&rec=true```


### Additional Requirements

#### for POST request

When making a POST request to `http://localhost:5000/api/places/`, you need to include a **body**. Here's an example body in JSON:

_**NOTE:** state & seasonVisited are not required properties. All the rest are_

```json
{
    "city": "Paris",
    "state": "",
    "country": "France",
    "seasonVisited": "autumn",
    "rating": 4,
    "review": "Beautiful lights, would love to visit.",
    "user_Name": "Luckie"
}
```


#### for PUT request
When making a PUT request to `http://localhost:5000/api/places/{id}`, you need to include a body that includes the place's `placeId` property. Here's an example body in JSON:

```json
{
    "placeId": 7,
    "city": "Paris",
    "state": "",
    "country": "France",
    "seasonVisited": "fall",
    "rating": 4,
    "review": "Beautiful lights, would love to visit.",
    "user_Name": "Luckie"
}
```

And here's the request we would send the body to:

`PUT http://localhost:5000/api/places/7`

_**NOTE:** the id number in the request URL must match the `placeId` for the place you'd like to update_

### Stretch Plans

* Add `PATCH` functionality
* Add user authentication with Identity
* As a user, I want to `DELETE` reviews, but only if I wrote them.

**FURTHER EXPLORATION TOPICS:**
> * Token-Based Authentication
> * API Versioning
> * Pagination
> * Enable CORS