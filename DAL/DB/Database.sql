create database if not exists prospects character set utf8 collate utf8_unicode_ci;
use prospects;

grant all privileges on prospects.* to 'prospects_user'@'localhost' identified by 'secret';