## READ ME

# Part 1 Competitive Analysis
The first website I found that could be competitive is [AirportWeather.com](https://airportweather.com/) This website allows a user to either select an airport on a map or enter it in the search bar to receive information about the weather. It is only functional so far for Europe. When I entered the ICAO code for London Heathrow (EGLL) the URL changed to https://airportweather.com/egll. When I did an inspection of the website, it does not appear bootstrap is used. I did recognize some JavaScript and json being used as well as CSS and HTML. 

The second website I found is [FlightStats](https://www.flightstats.com). They have a section of their website where you can enter airport conditions for a certain website. This website has iframe usage which I did not recognize. There is not apparent bootstrap usage. There is script usage and when you search airport conditions, a URL change. When searching the conditions for Pittsburgh International Airport, it changes the URL to https://www.flightstats.com/v2/airport-conditions/PIT.\

The third website I found is [FlightAware](https://www.flightaware.com). This website shows a map with current airport delays and things of that nature. There is a map with different airport codes and a color indicator of the conditions there. It also shows a current radar.  This website is the most complex one I have seen. The code is very long and contains many parts.  Lots of iframe, script, and div usage. There are also many URL changes. 

# Part 2 GitHub Repositories
https://github.com/parkersiu/airport-weather/blob/main/index.html
This repository is interesting. The author is a licensed pilot who wanted to make an application for pilots to search weather conditions at airports. According to the README, there is Bootstrap, CSS, and HTML usage.  

https://github.com/BraedenKilburn/AviationWeatherReports/tree/master/front-end
This repository has code that can deliver reports for Pilot use such as METAR. This is interesting because it is something they need to do their flights. There is json use and the author has it nicely organized between forn-end and back-end. 

# Part 3 

## Citations
I used [ChatGPT 3.5](https://www.chat.openai.com) to assist with JavaScript on the page where the delays for the U.S. and Europe are. I had began to develop code and got lost, and asked it the following prompt to help clean up my code. 
Help me make this button and function operational in JavaScript <script> function AverageDelayCalc(p1, p2){ return "The Average Number of Delays are: "((p1 + p2) / 2); } let result = AverageDelayCalc(100, 250) </script> <button type="button" onclick="AverageDelayCalc(p1, p2)" id="DelayCalc">Click to see the Average Delays for the last 7 days between the U.S. and Europe</button> <script> document.getElementById("AverageDelays").innerHTML = result </script>

I also used [w3 Schools](https://www.w3schools.com) as a resource for this project. I used it to help with creating HTML code for tables and forms, and some review of the basics. I also utilized class code as a resource as well.

[Bootswatch](https://bootswatch.com/) was used to find a theme for Bootsrap 5 use. I chose Lux for this version ot the prototype. 
## Status and Improvement
For this assignment, I did not achieve everything I had hoped to. Moving forward, I want to focus on some areas to make my prototype better and become better at application coding. Some of those things are:
| Rank | Areas for Improvement																	  |
|-----:|------------------------------------------------------------------------------------------|
|     1| Practicing code examples given in class more											  |
|     2|Utilizing https://www.w3schools.com and other resources to supplement learning            |
|     3|Asking more questions when confused														  |


As for the prototype itself, I would like to see it be more aesthetic and functional. I want to add more pages that show weather conditions when searching specific airports, and improving the existing ones. The existing ones have a lot of potential, and I would like to develop the to show more data.

## Page 1
Page 1 is a homepage. I have a table that I want to make more advanced that will show the airports with delays in real time. I then have a button to go to the next page, which has delay information for the last 7 days. 

## Page 2
Page 2 will have delay information for the last 7 days for top airports in the U.S. and Europe. 

## Research Findings
The websites I researched I found to be a bit complicated to analyze. I want to look at them more as I am working on this prototype more. https://w3schools.com was by far the most helpful resource I used. Using ChatGPT was helpful to clean up code I had written and had a few syntax errors or tiny mistakes my eyes were missing. I don't typically like using Generative AI because I feel like I miss out on the challenge of trying to fiugre it out on my own, and I also don't trust the results it delivers. 