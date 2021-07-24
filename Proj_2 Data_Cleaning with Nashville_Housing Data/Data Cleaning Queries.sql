/* 

Cleaning Data in SQL Quries

*/


-- Importing Data 

CREATE TABLE housing
(
	UniqueID INT PRIMARY KEY,
	ParcelID VARCHAR(100),
	LandUse NUMERIC,
	PropertyAddress VARCHAR(10000),
	SaleDate DATE,
	SalePrice VARCHAR(100), 
	LegalReference VARCHAR(10000),
	SoldAsVacant VARCHAR(50),
	OwnerName VARCHAR(10000),
	OwnerAddress VARCHAR(10000),
	Acreage NUMERIC,
	TaxDistrict VARCHAR(100),
	LandValue INTEGER,
	BuildingValue INTEGER,
	TotalValue INTEGER,
	YearBuilt SMALLINT,
	Bedrooms SMALLINT,
	FullBath SMALLINT,
	HalfBath SMALLINT
);


COPY housing
FROM '/Users/madinakhongiyasova/Downloads/housingDate.csv'
DELIMITER ',' CSV HEADER; 




-- Standardize Data Format 



UPDATE housing
SET SaleDate = SaleDate :: DATE;

ALTER TABLE housing 
ADD SaleDateConterted DATE;

UPDATE housing 
SET SaleDateConterted = SaleDate :: Date;

SELECT saledateconterted, SaleDate :: Date
FROM housing;



-- Populate Property Address data 



SELECT *
FROM housing
ORDER BY ParcelID;

SELECT a.ParcelID, a.PropertyAddress, b.ParcelID, 
b.PropertyAddress, COALESCE(a.PropertyAddress, b.PropertyAddress)
FROM housing a
JOIN housing b
	on a.ParcelID = b.ParcelID
	AND a.UniqueID <> b.UniqueID
WHERE a.PropertyAddress is null;

UPDATE  housing
SET PropertyAddress = COALESCE(a.PropertyAddress, b.PropertyAddress)
FROM Housing a 
JOIN Housing b
	on a.ParcelID = b.ParcelID
	AND a.UniqueID <> b.UniqueID
WHERE a.PropertyAddress is null;


-- Breaking out Address into individual columns (address, City, State)


SELECT 
SUBSTRING(PropertyAddress, 1, POSITION( ',' in PropertyAddress)-1) as address,
SUBSTRING(PropertyAddress, POSITION( ',' in PropertyAddress)+1, LENGTH(PropertyAddress)) 
as Address
FROM Housing;


ALTER TABLE Housing
ADD address VARCHAR(256);

ALTER TABLE Housing
RENAME COLUMN address to property_address;

UPDATE Housing
SET property_address = SUBSTRING(PropertyAddress, 1, POSITION( ',' in PropertyAddress)-1);


ALTER TABLE Housing
ADD city VARCHAR(256);

ALTER TABLE Housing
RENAME COLUMN city to property_city;

UPDATE Housing
SET property_city = SUBSTRING(PropertyAddress, POSITION( ',' in PropertyAddress)+1, LENGTH(PropertyAddress)); 
 
 
-- Splitting OwnerAddress



SELECT owneraddress
FROM Housing;

SELECT SPLIT_PART(owneraddress,',', 1) as address,
SPLIT_PART(owneraddress,',', 2) as city,
SPLIT_PART(owneraddress,',', 3) as state
FROM Housing;


ALTER TABLE Housing
ADD owner_address VARCHAR(256);

UPDATE Housing
SET owner_address = SPLIT_PART(owneraddress,',', 1);


ALTER TABLE Housing
ADD owner_city VARCHAR(256);

UPDATE Housing
SET owner_city = SPLIT_PART(owneraddress,',', 2); 
 
 
ALTER TABLE Housing
ADD owner_state VARCHAR(256);

UPDATE Housing
SET owner_state = SPLIT_PART(owneraddress,',', 3);



-- Changing Y and N to YES and NO in 'Solid as Vacant'



SELECT DISTINCT(soldasvacant), COUNT(SoldAsVacant)
FROM Housing
GROUP BY SoldAsVacant
ORDER BY 2;



SELECT SoldAsVacant,
CASE WHEN SoldAsVacant = 'Y' THEN 'Yes'
	 WHEN SoldAsVacant = 'N' THEN 'No'
	 ELSE SoldAsVacant
	 END
FROM Housing;

UPDATE Housing
SET SoldAsVacant= CASE WHEN SoldAsVacant = 'Y' THEN 'Yes'
	 WHEN SoldAsVacant = 'N' THEN 'No'
	 ELSE SoldAsVacant
	 END
	 



-- Removing Duplicates 



DELETE
FROM Housing WHERE UniqueID in (
WITH RowNumCTE AS(
SELECT *,
	ROW_NUMBER() OVER ( 
	PARTITION BY ParcelID,
				 PropertyAddress,
				 SalePrice,
				 LegalReference
				 ORDER BY 
				 	UniqueID
					) row_num
FROM Housing
)
SELECT UniqueID FROM RowNumCTE WHERE row_num > 1);



-- Deleting Unused Columns 


ALTER TABLE housing 
DROP COLUMN OwnerAddress,
DROP COLUMN TaxDistrict, 
DROP COLUMN PropertyAddress, 
DROP COLUMN SaleDate;











 




