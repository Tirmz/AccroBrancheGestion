CREATE PROCEDURE 'DeleteVenteEmpty'
BEGIN

DELETE from vente
where idVente NOT IN(select idVente from LignedeVente);

END
