/*
Covid 19 Data Exploration 
Skills used: Joins, CTE's, Temp Tables, Windows Functions, Aggregate Functions, Creating Views, Converting Data Types
*/


SELECT * FROM covid_vacination
order by 3,4;
SELECT * FROM covid_death
WHERE continent IS NOT NULL 
ORDER BY 3,4;


-- Select Data that we are going be using 


SELECT location, date, total_cases, new_cases, total_deaths, 
population
FROM covid_death 
WHERE continent IS NOT NULL 
ORDER BY 1, 2;



-- Total Cases vs Total Deaths
-- Shows likelihood of dying if your contract covid in your country


SELECT location, date, total_cases, total_deaths, ROUND(((total_deaths/total_cases)*100),4) as death_percentage
FROM covid_death 
WHERE location LIKE '%States%'
AND continent IS NOT NULL 
ORDER BY 1, 2;


--Total Cases vs Population
-- Shows what percentage of population got COVID


SELECT location, date, total_cases, population, ROUND(((total_cases/population)*100),4) 
AS infected_population
FROM covid_death 
WHERE continent IS NOT NULL 
ORDER BY 1, 2;


-- Countries with highest infection rate compared to population


SELECT location, population, MAX(total_cases) as highest_infection, ROUND(((MAX(total_cases)/population)*100),4) as infected_population
FROM covid_death 
WHERE continent IS NOT NULL AND 
total_cases IS NOT NULL
GROUP BY location, population
ORDER BY infected_population DESC;


-- Countries With Highest Death Count per Population


SELECT location, MAX(CAST(total_deaths as INTEGER))as total_death_count
FROM covid_death 
WHERE continent IS NOT NULL AND 
total_deaths IS NOT NULL
GROUP BY location, population
ORDER BY total_death_count DESC;

-- Breaking down by continent

-- Continents with highest death count per population


SELECT continent, MAX(CAST(total_deaths as INTEGER))as total_death_count
FROM covid_death 
WHERE continent IS NOT NULL
GROUP BY continent
ORDER BY total_death_count DESC;



-- Global Numbers


SELECT  SUM(new_cases :: NUMERIC) as total_cases, SUM(CAST(new_deaths AS NUMERIC)) as total_deaths,
ROUND((SUM(CAST(new_deaths AS NUMERIC))/SUM(new_cases :: NUMERIC)*100),4)as death_percentage
FROM covid_death 
WHERE continent IS NOT NULL 
--GROUP BY date
ORDER BY 1, 2;



-- Total Population vs Vaccinations


SELECT covid_death.continent, covid_death.location, covid_death.date, covid_death.population,covid_vacination.new_vaccinations, SUM(covid_vacination.new_vaccinations :: INTEGER) OVER (PARTITION BY  covid_death.location ORDER BY covid_death.location, 
covid_death.date) AS rolling_people_vaccinated
FROM covid_death
INNER JOIN covid_vacination 
 ON covid_death.location = covid_vacination.location
 AND covid_death.date = covid_vacination.date
WHERE covid_death.continent IS NOT NULL
ORDER BY 2,3;


-- Using CTE to perform Calculation on Partition By in previous query


WITH PopvsVac (continent, location, date, population, new_vaccinations, rolling_people_vaccinated)
AS
(
SELECT covid_death.continent, covid_death.location, covid_death.date, covid_death.population,covid_vacination.new_vaccinations, SUM(covid_vacination.new_vaccinations :: INTEGER) OVER (PARTITION BY  covid_death.location ORDER BY covid_death.location, 
covid_death.date) AS rolling_people_vaccinated
FROM covid_death
INNER JOIN covid_vacination 
 ON covid_death.location = covid_vacination.location
 AND covid_death.date = covid_vacination.date
WHERE covid_death.continent IS NOT NULL
)
SELECT *, ROUND(((rolling_people_vaccinated/population)*100),4)
FROM PopvsVac;



-- Using Temp Table to perform Calculation on Partition By in previous query


DROP TABLE IF EXISTS percent_population_vaccinated;
CREATE TABLE percent_population_vaccinated 
(
	continent VARCHAR(500),
	location VARCHAR(500),
	date DATE,
	population NUMERIC,
	new_vaccinations VARCHAR(500),
	rolling_people_vaccinated NUMERIC 
);

INSERT INTO percent_population_vaccinated 
SELECT covid_death.continent, covid_death.location, covid_death.date, covid_death.population,covid_vacination.new_vaccinations, SUM(covid_vacination.new_vaccinations :: INTEGER) OVER (PARTITION BY  covid_death.location ORDER BY covid_death.location, 
covid_death.date) AS rolling_people_vaccinated
FROM covid_death
INNER JOIN covid_vacination 
 ON covid_death.location = covid_vacination.location
 AND covid_death.date = covid_vacination.date;

SELECT *, ROUND(((rolling_people_vaccinated/population)*100),4)
FROM percent_population_vaccinated;


-- Creating VIEW to store data for later visualization



CREATE VIEW  vaccinated_population_percent AS
SELECT covid_death.continent, covid_death.location, covid_death.date, covid_death.population,covid_vacination.new_vaccinations, SUM(covid_vacination.new_vaccinations :: INTEGER) OVER (PARTITION BY  covid_death.location ORDER BY covid_death.location, 
covid_death.date) AS rolling_people_vaccinated
FROM covid_death
INNER JOIN covid_vacination 
 ON covid_death.location = covid_vacination.location
 AND covid_death.date = covid_vacination.date
WHERE covid_death.continent IS NOT NULL;


CREATE VIEW cases_vs_deaths AS
SELECT location, date, total_cases, total_deaths, ROUND(((total_deaths/total_cases)*100),4) as death_percentage
FROM covid_death 
WHERE location LIKE '%States%'
AND continent IS NOT NULL 
ORDER BY 1, 2;

CREATE VIEW cases_population AS
SELECT location, date, total_cases, population, ROUND(((total_cases/population)*100),4) 
AS infected_population
FROM covid_death 
WHERE continent IS NOT NULL 
ORDER BY 1, 2;


CREATE VIEW max_infection_rate AS
SELECT location, population, MAX(total_cases) as highest_infection, ROUND(((MAX(total_cases)/population)*100),4) as infected_population
FROM covid_death 
WHERE continent IS NOT NULL AND 
total_cases IS NOT NULL
GROUP BY location, population
ORDER BY infected_population DESC;


CREATE VIEW higest_death_count AS
SELECT location, MAX(CAST(total_deaths as INTEGER))as total_death_count
FROM covid_death 
WHERE continent IS NOT NULL AND 
total_deaths IS NOT NULL
GROUP BY location, population
ORDER BY total_death_count DESC;

