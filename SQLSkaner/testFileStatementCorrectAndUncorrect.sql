
select avg(pudelka.masa) as "Srednia waga" from
(select sum(z.sztuk*c.masa) as masa from zawartosc z natural join czekoladki c group by z.idpudelka) pudelka;

select pudelka.idpudelka, pudelka.masa from
(select idpudelka, sum(z.sztuk*c.masa) masa from zawartosc z natural join czekoladki c
group by z.idpudelka) pudelka
where pudelka.masa = (select max(pudelko.masa)
 from (select idpudelka, sum(z.sztuk*c.masa) as masa from zawartosc z natural join czekoladki c group by z.idpudelka)
 pudelko);
 
select datarealizacji, count(idzamowienia) as "Ilosc" from zamowienia
group by datarealizacji;

SELECT EntityID, EntityName, 
       CASE WHEN EntityProfile IS NULL THEN FALSE ELSE TRUE END AS HasProfile
FROM Entity

select idczekoladki, nazwa, masa, koszt from czekoladki where masa > 15 and masa < 24
(where masa between 15 and 24);

select nazwa, czekolada, nadzienie, orzechy from czekoladki where (czekolada = "mleczna" and nadzienie in ("truskawka", "malina")) or orzechy = "laskowe" and czekolada <> "gorzka";

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where nazwa like "S%i" order by 2;

select nazwa, ulica, miejscowosc from klienci where miejscowosc = "Kraków" order by 1;

select idpudelka, sum(sztuk) from zawartosc group by idpudelka
order by 2 desc
limit 1;

Integer BoOLeAn FLOAT chaRACTER

2.123 z.421 0.123 0.0

select zamowienia.rok, zamowienia.kwartal, sum(zamowienia.ilosc)
from (select case	
	when (extract(month from datarealizacji) < 4 then "pierwszy"
	when (extract(month from datarealizacji) > 3 and 
		(extract(month from datarealizacji) < 7 then "drugi"
	when (extract(month from datarealizacji) > 6 and 
		(extract(month from datarealizacji) < 10 then "trzeci"
	else "czwarty" end as kwartal,
	
	extract (year from datarealizacji) as rok, count(idzamowienia) as ilosc from zamowienia
	group by rok, kwartal) zamowienia
	
	group by zamowienia.rok, zamowienia.kwartal;
	
select miejscowosc, count(idzamowienia)
from klienci natural join zamowienia
group by 1
order by 1;

select sum(zamowienia.zysk) from
(select idpudelka, sum(a.sztuk*(zyskPudelko.cena-zyskPudelko.koszt)) as zysk from
(select idpudelka, p.cena as cena, sum(z.sztuk * c.koszt) as koszt from pudelka p 
natural join zawartosc z join czekoladki c using (idczekoladki) group by idpudelka) zyskPudelko join artykuly a using (idpudelka) group by idpudelka) zamowienia;

DELETE FROM klienci WHERE idklienta > 91 and idklienta < 100;

select 1+3;


INSERT INTO zawartosc VALUES ("X99", "m00", 2), 
("X99", "m01", 2),
("X99", "m02", 2),
("X99", "m03", 2),
("X99", "m04", 2);

UPDATE 	czekoladki SET czekolada = 			"brak"		where czekolada is null;
UPDATE  czekoladki SET 		orzechy = 		"brak" 		where orzechy   is null;
UPDATE  czekoladki SET 			nadzienie = "brak" 		where nadzienie is null;

	select count(*) from czekoladki;

CREATE TABLE exampleTable;
DROP TABLE exampleTable;
