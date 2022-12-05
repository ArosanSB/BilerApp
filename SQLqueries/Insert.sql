select * from Bil

-- Find funktion
select RegNr, Model, Mærke, aargang from Bil
where Aargang = 2022

-- Update funktion
update Bil
set kM = 2500
where RegNr = 'CH97259'

-- Delete funktion
delete from Bil where RegNr = 'Vip YH6'



update Bil
set kM = 9050
where RegNr = 'VIP YH6'