select nazwa, ulica, miejscowosc from klienci order by 1;

select nazwa, ulica, miejscowosc from klienci order by 3 desc, 1 asc;

select nazwa, ulica, miejscowosc from klienci where miejscowosc in ("Kraków", "Warszawa") order by 3 desc, 1 asc;
select nazwa, ulica, miejscowosc from klienci where miejscowosc = "Kraków" or miejscowosc = "Warszawa" order by 3 desc, 1 asc;

select nazwa, ulica, miejscowosc from klienci order by 3 desc;

select nazwa, ulica, miejscowosc from klienci where miejscowosc = "Kraków" order by 1;

select nazwa, masa, koszt from czekoladki where masa > 20 and koszt > 0.25;

select nazwa, masa, koszt*100 as Koszt from czekoladki where masa > 20 and koszt*100 > 25;

select nazwa, czekolada, nadzienie, orzechy from czekoladki where (czekolada = "mleczna" and nadzienie in ("truskawka", "malina")) or orzechy = "laskowe" and czekolada <> "gorzka";

select nazwa, koszt from czekoladki where koszt > 0.25;

select nazwa, czekolada from czekoladki where czekolada in ("mleczna", "biała");


select 124 * 7 + 45;
select sqrt(3);
select pi();


select idczekoladki, nazwa, masa, koszt from czekoladki where masa > 15 and masa < 24
(/where masa between 15 and 24);

select idczekoladki, nazwa, masa, koszt from czekoladki where koszt between 0.25 and 0.35;

select idczekoladki, nazwa, masa, koszt from czekoladki where (masa between 15 and 24) or (koszt between 0.25 and 


select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where orzechy is not null;

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where orzechy is null;

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where orzechy is not null or nadzienie is not null;

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where czekolada in ("mleczna", "biała") and orzechy is null;

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where czekolada not in ("mleczna", "biała") and (orzechy is not null or nadzienie is not null);

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where nadzienie is not null;

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where nadzienie is null;

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where orzechy is null and nadzienie is null;

select idczekoladki, nazwa, czekolada, orzechy, nadzienie from czekoladki where czekolada in ("mleczna", "biała") and nadzienie is null;

UPDATE klienci SET nazwa = "Nowak Iza" where nazwa = "Matusiak Iza";

UPDATE czekoladki SET koszt = koszt * 0.9 where idczekoladki in ("W98", "M98", "X91");

UPDATE czekoladki SET koszt = (select koszt from czekoladki where idczekoladki = "W98") where nazwa = "Nieznana Nieznajoma";

UPDATE klienci SET miejscowosc = "Piotrograd" where miejscowosc = "Leningrad";

UPDATE czekoladki SET koszt = koszt + 0.15 where idczekoladki like "%9%" and idczekoladki not like "%90";

DELETE FROM klienci where nazwa like "Matusiak %";

DELETE FROM klienci WHERE idklienta > 91 and idklienta < 100;

DELETE FROM czekoladki where koszt >= 0.45 or masa >= 36 or masa = 0;

INSERT INTO pudelka VALUES ("X99", "newbox1", "11111", 99, 10), ("Z99", "newbox2", "11112", 98, 10);

INSERT INTO zawartosc VALUES ("X99", "m00", 2), 
("X99", "m01", 2),

UPDATE zawartosc SET sztuk = sztuk + 1
("X99", "m02", 2),
("X99", "m03", 2),
("X99", "m04", 2);

INSERT INTO zawartosc VALUES ("Z99", "m00", 2), 
("Z99", "m01", 2),
("Z99", "m02", 2),
("Z99", "m03", 2),
("Z99", "m04", 2);WHERE idpudelka in ("X99", "Z99", "nice", "game");

UPDATE czekoladki SET czekolada = "brak" where czekolada is null;
UPDATE czekoladki SET orzechy = "brak" where orzechy is null;
UPDATE czekoladki SET nadzienie = "brak" where nadzienie is null;

UPDATE czekoladki SET czekolada = null where czekolada = "brak";
UPDATE czekoladki SET orzechy = null where orzechy = "brak";
UPDATE czekoladki SET nadzienie = null where nadzienie = "brak";