--Pokud přidám databázi přes grafické rozhraní, nebude mít české řazení, spouštím 

ALTER DATABASE jmeno_databze
COLLATE Czech_CI_AS;
--COLLATE Latin1_General_100_CI_AS_SC_UTF8;
