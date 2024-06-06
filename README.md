# FizzBuzz

This is a simple web api.

The api accepts List of strings as arguments.

The api would do below.

for each value in list 
{ 
If the value is a multiple of 3 then output the word “Fizz”
If the value is a multiple of 5 then output the word “Buzz”
If the value is divisible by both 3 and 5 then output the word “FizzBuzz” 
}

------------------------------------------------------------------------------------
Running the solution:
you would need visual studio 2022 to run this.
this is based on visual studio built in .net 8 template.

Open the solution in visual studio 2022 and press green button
------------------------------------------------------------------------------------
Run an sample request:

you can use the packaged swagger page or 
use curl like below.



Request:

curl -X 'GET' \
  'https://localhost:7174/api/execute?inputs=A&inputs=23&inputs=12' \
  -H 'accept: text/plain'

Response:

  [
  {
    "input": "A",
    "results": [
      "Invalid Item"
    ]
  },
  {
    "input": "23",
    "results": [
      "Divided 23 by 3",
      "Divided 23 by 5"
    ]
  },
  {
    "input": "12",
    "results": [
      "Fizz"
    ]
  }
]