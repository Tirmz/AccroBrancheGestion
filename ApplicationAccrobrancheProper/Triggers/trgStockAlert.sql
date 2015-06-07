DELIMITER //
CREATE TRIGGER `Stock_Update` BEFORE INSERT ON `LignedeVente` FOR EACH ROW
BEGIN
	DECLARE stock integer;
	
	SELECT quantiteStockProduit INTO stock
	FROM Produit
	WHERE idProduit = NEW.idProduit;
	
	IF (stock - NEW.quantiteVente) < 0 THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Stock pas assez approvisionne', MYSQL_ERRNO = 1000;
    ELSE
        UPDATE Produit SET quantiteStockProduit = quantiteStockProduit - NEW.quantiteVente
        WHERE idProduit = NEW.idProduit;
	END IF;
	
END//

DELIMITER ;