-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 10 Haz 2022, 19:01:45
-- Sunucu sürümü: 8.0.21
-- PHP Sürümü: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `galeri_satıs`
--

DELIMITER $$
--
-- Yordamlar
--
DROP PROCEDURE IF EXISTS `galeri_MusteriBakiye`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_MusteriBakiye` (`id` VARCHAR(64))  BEGIN
	declare borc  float;
    declare odeme float;
    
	SELECT 	SUM(satis_fiyat) into borc  
    FROM 	galeri_satislar 
    WHERE 	musteri_id = id;
    
    SELECT 	SUM(odeme_tutar) into odeme  
    FROM 	galeri_odemeler 
    WHERE 	musteri_id = id;
    
    SELECT odeme - borc;
END$$

DROP PROCEDURE IF EXISTS `galeri_MusteriBul`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_MusteriBul` (`filtre` VARCHAR(32))  BEGIN
	SELECT * FROM galeri_musteriler
    WHERE 
    	musteri_id  	LIKE  CONCAT('%',filtre,'%') OR
		musteri_ad		LIKE  CONCAT('%',filtre,'%') OR
		musteri_soyad 	LIKE  CONCAT('%',filtre,'%') OR
		musteri_tel 	LIKE  CONCAT('%',filtre,'%') OR
		musteri_mail 	LIKE  CONCAT('%',filtre,'%') OR
		musteri_adres 	LIKE  CONCAT('%',filtre,'%');
END$$

DROP PROCEDURE IF EXISTS `galeri_musteriekle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_musteriekle` (`id` VARCHAR(64), `ad` VARCHAR(64), `soy` VARCHAR(64), `tel` VARCHAR(25), `mail` VARCHAR(250), `adr` VARCHAR(250))  BEGIN
	INSERT INTO galeri_musteriler
    VALUES 	(id, ad, soy, tel, mail, adr);
END$$

DROP PROCEDURE IF EXISTS `galeri_MusteriGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_MusteriGuncelle` (`id` VARCHAR(64), `ad` VARCHAR(64), `soy` VARCHAR(64), `tel` VARCHAR(25), `mail` VARCHAR(250), `adr` VARCHAR(250))  BEGIN
	UPDATE galeri_musteriler
    SET 
		musteri_ad		= ad,
		musteri_soyad 	= soy,
		musteri_tel 	= tel,
		musteri_mail 	= mail,
		musteri_adres 	= adr
	WHERE 
    	musteri_id  	= id;
END$$

DROP PROCEDURE IF EXISTS `galeri_musterilerHepsi`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_musterilerHepsi` ()  BEGIN
	SELECT 
		musteri_id 		as ID,
		musteri_ad 		as Adı,
		musteri_soyad 	as Soyadı,
		musteri_tel		as Telefon, 
		musteri_mail 	as Mail,
		musteri_adres 	as Adres
    FROM galeri_musteriler;
END$$

DROP PROCEDURE IF EXISTS `galeri_MusteriSatislar`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_MusteriSatislar` (`id` VARCHAR(64))  BEGIN
	SELECT * FROM galeri_satislar
    WHERE musteri_id = id;
END$$

DROP PROCEDURE IF EXISTS `galeri_MusteriSil`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_MusteriSil` (`id` VARCHAR(64))  BEGIN
	DELETE FROM galeri_musteriler
	WHERE  	musteri_id  = id;
END$$

DROP PROCEDURE IF EXISTS `galeri_OdemeDetay`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_OdemeDetay` ()  BEGIN
SELECT   
		o.odeme_id,
        m.musteri_id,
        CONCAT(musteri_ad,' ', musteri_soyad ) as `Müşteri Ad Soyad`,
        o.odeme_tarih as `Ödeme Tarihi`,
        o.odeme_tutar as `Ödeme Tutarı`,
        o.odeme_tur as `Ödeme Türü`,
        o.odeme_aciklama as `Açıklama`
		
FROM  	galeri_musteriler m inner join  galeri_odemeler o 
	on m.musteri_id = o.musteri_id;
END$$

DROP PROCEDURE IF EXISTS `galeri_OdemeEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_OdemeEkle` (`oid` VARCHAR(64), `mid` VARCHAR(64), `tarih` DATETIME, `tutar` FLOAT, `tur` VARCHAR(25), `aciklama` VARCHAR(250))  BEGIN
	INSERT INTO galeri_odemeler
    VALUES 	(oid, mid, tarih, tutar, tur, aciklama);
END$$

DROP PROCEDURE IF EXISTS `galeri_OdemeGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_OdemeGuncelle` (`oid` VARCHAR(64), `mid` VARCHAR(64), `tarih` DATETIME, `tutar` FLOAT, `tur` VARCHAR(25), `aciklama` VARCHAR(250))  BEGIN
	UPDATE galeri_odemeler
    SET
		musteri_id		= mid,
        odeme_tarih		= tarih,
        odeme_tutar		= tutar,
        odeme_tur		= tur,
        odeme_aciklama 	= aciklama
 	WHERE 
		odeme_id = oid; 
END$$

DROP PROCEDURE IF EXISTS `galeri_odemelerToplam`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_odemelerToplam` ()  BEGIN
    SELECT 	SUM(odeme_tutar)  
    FROM 	galeri_odemeler ;
END$$

DROP PROCEDURE IF EXISTS `galeri_OdemeSil`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_OdemeSil` (`oid` VARCHAR(64))  BEGIN
	DELETE FROM galeri_odemeler
    WHERE odeme_id = oid;
END$$

DROP PROCEDURE IF EXISTS `galeri_SatisDetay`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_SatisDetay` ()  BEGIN
SELECT   
		s.satis_id,
        m.musteri_id,
        u.urun_id,
        CONCAT(musteri_ad,' ', musteri_soyad ) as `Müşteri Ad Soyad`,
        urun_ad as `Ürün`,
        urun_kategori as `Kategori`,
        urun_fiyat as `Birim Fiyat`,
        satis_fiyat as `Satış Fiyatı`,
		satis_tarih as `Satış Tarihi`
FROM  	galeri_musteriler m inner join  galeri_satislar s 
	on m.musteri_id = s.musteri_id 
		inner join galeri_urunler u on s.urun_id = u.urun_id;
END$$

DROP PROCEDURE IF EXISTS `galeri_SatisEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_SatisEkle` (`sid` VARCHAR(64), `mid` VARCHAR(64), `uid` VARCHAR(64), `tarih` DATETIME, `fiyat` FLOAT)  BEGIN
	INSERT INTO galeri_satislar
    VALUES 	(sid, mid, uid, tarih, fiyat);
END$$

DROP PROCEDURE IF EXISTS `galeri_SatisGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_SatisGuncelle` (`sid` VARCHAR(64), `mid` VARCHAR(64), `uid` VARCHAR(64), `tarih` DATETIME, `fiyat` FLOAT)  BEGIN
	UPDATE galeri_satislar
    SET 
		musteri_id    = mid,
		urun_id 	  = uid,
		satis_tarih	  = tarih,
		satis_fiyat	  = fiyat
	WHERE 
		satis_id 	  = sid;
END$$

DROP PROCEDURE IF EXISTS `galeri_satislarToplam`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_satislarToplam` ()  BEGIN
	SELECT 	SUM(satis_fiyat)  
    FROM 	galeri_satislar ;
END$$

DROP PROCEDURE IF EXISTS `galeri_SatisSil`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_SatisSil` (`id` VARCHAR(64))  BEGIN
	DELETE FROM galeri_satislar
	WHERE satis_id  = id;
END$$

DROP PROCEDURE IF EXISTS `galeri_UrunBul`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_UrunBul` (`filtre` VARCHAR(32))  BEGIN
	SELECT * FROM galeri_urunler
    WHERE 
    	urun_id  	  LIKE  CONCAT('%',filtre,'%') OR
		urun_ad 	  LIKE  CONCAT('%',filtre,'%') OR
		urun_kategori LIKE  CONCAT('%',filtre,'%') OR
		urun_fiyat 	  LIKE  CONCAT('%',filtre,'%') OR
		urun_stok	  LIKE  CONCAT('%',filtre,'%') OR
		urun_birim	  LIKE  CONCAT('%',filtre,'%') OR
		urun_detay	  LIKE  CONCAT('%',filtre,'%') ;
END$$

DROP PROCEDURE IF EXISTS `galeri_UrunEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_UrunEkle` (`id` VARCHAR(64), `ad` VARCHAR(250), `kategori` VARCHAR(250), `fiyat` FLOAT, `stok` FLOAT, `birim` VARCHAR(16), `detay` VARCHAR(250))  BEGIN
	INSERT INTO galeri_urunler
    VALUES 	(id, ad, kategori, fiyat, stok, birim, detay);
END$$

DROP PROCEDURE IF EXISTS `galeri_UrunGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_UrunGuncelle` (`id` VARCHAR(64), `ad` VARCHAR(250), `kategori` VARCHAR(250), `fiyat` FLOAT, `stok` FLOAT, `birim` VARCHAR(16), `detay` VARCHAR(250))  BEGIN
	UPDATE galeri_urunler
    SET 
		urun_ad 	  = ad,
		urun_kategori = kategori,
		urun_fiyat 	  = fiyat,
		urun_stok	  = stok,
		urun_birim	  = birim,
		urun_detay	  = detay
	WHERE 
    	urun_id  	  = id;
END$$

DROP PROCEDURE IF EXISTS `galeri_urunlerHepsi`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_urunlerHepsi` ()  BEGIN
	SELECT * FROM galeri_urunler;
END$$

DROP PROCEDURE IF EXISTS `galeri_UrunSatislar`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_UrunSatislar` (`id` VARCHAR(64))  BEGIN
	SELECT * FROM galeri_satislar
    WHERE urun_id = id;
END$$

DROP PROCEDURE IF EXISTS `galeri_UrunSil`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_UrunSil` (`id` VARCHAR(64))  BEGIN
	DELETE FROM galeri_urunler
	WHERE urun_id  = id;
END$$

DROP PROCEDURE IF EXISTS `galeri_UrunStokGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `galeri_UrunStokGuncelle` (`id` VARCHAR(64), `stok` FLOAT)  BEGIN
	UPDATE galeri_urunler
    SET 
		urun_stok	  = stok
	WHERE 
    	urun_id  	  = id;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `galeri_musteriler`
--

DROP TABLE IF EXISTS `galeri_musteriler`;
CREATE TABLE IF NOT EXISTS `galeri_musteriler` (
  `musteri_id` varchar(64) NOT NULL,
  `musteri_ad` varchar(64) NOT NULL,
  `musteri_soyad` varchar(64) NOT NULL,
  `musteri_tel` varchar(25) NOT NULL,
  `musteri_mail` varchar(250) NOT NULL,
  `musteri_adres` varchar(250) NOT NULL,
  PRIMARY KEY (`musteri_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `galeri_odemeler`
--

DROP TABLE IF EXISTS `galeri_odemeler`;
CREATE TABLE IF NOT EXISTS `galeri_odemeler` (
  `odeme_id` varchar(64) NOT NULL,
  `musteri_id` varchar(64) NOT NULL,
  `odeme_tarih` datetime NOT NULL,
  `odeme_tutar` float NOT NULL,
  `odeme_tur` varchar(25) NOT NULL,
  `odeme_aciklama` varchar(250) NOT NULL,
  PRIMARY KEY (`odeme_id`),
  KEY `musteri_id` (`musteri_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `galeri_satislar`
--

DROP TABLE IF EXISTS `galeri_satislar`;
CREATE TABLE IF NOT EXISTS `galeri_satislar` (
  `satis_id` varchar(64) NOT NULL,
  `musteri_id` varchar(64) NOT NULL,
  `urun_id` varchar(64) NOT NULL,
  `satis_tarih` datetime NOT NULL,
  `satis_fiyat` float NOT NULL,
  PRIMARY KEY (`satis_id`),
  KEY `musteri_id` (`musteri_id`),
  KEY `urun_id` (`urun_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `galeri_satislar`
--

INSERT INTO `galeri_satislar` (`satis_id`, `musteri_id`, `urun_id`, `satis_tarih`, `satis_fiyat`) VALUES
('sat3', 'id1', 'ur1', '2009-10-10 00:00:00', 120);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `galeri_urunler`
--

DROP TABLE IF EXISTS `galeri_urunler`;
CREATE TABLE IF NOT EXISTS `galeri_urunler` (
  `urun_id` varchar(64) NOT NULL,
  `urun_ad` varchar(250) NOT NULL,
  `urun_kategori` varchar(250) NOT NULL,
  `urun_fiyat` float NOT NULL,
  `urun_stok` float NOT NULL,
  `urun_birim` varchar(16) NOT NULL,
  `urun_detay` varchar(250) NOT NULL,
  PRIMARY KEY (`urun_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
