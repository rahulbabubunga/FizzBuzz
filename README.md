# FizzBuzz

This is a simple web api.

The api accepts List of strings as arguments.

The api would do below.

for each value in list { If the value is a multiple of 3 then output the word “Fizz” If the value is a multiple of 5 then output the word “Buzz” If the value is divisible by both 3 and 5 then output the word “FizzBuzz” }

sample curl:

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