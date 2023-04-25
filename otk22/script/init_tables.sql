INSERT INTO `otk`.`roles` (`code`, `description`, `employee`) VALUES ('manager', 'Роль менеджера', '1');
INSERT INTO `otk`.`roles` (`code`, `description`) VALUES ('client', 'Роль клиент');

INSERT INTO `otk`.`customers` (`name`, `address`, `phone`) VALUES ('ОТК', '', '');
INSERT INTO `otk`.`customers` (`name`, `address`, `phone`) VALUES ('ООО Ромашка', 'г. Ростов-на-Дону, ул. Садовая, 26', '9282000001');
INSERT INTO `otk`.`customers` (`name`, `address`, `phone`) VALUES ('ООО Ремонтно Строительное Предприятие Асфальт', 'г. Батайск, ул. Горького, 27', '9283000003');
INSERT INTO `otk`.`customers` (`name`, `address`, `phone`) VALUES ('ИП Петров', 'г. Аксай, ул. Гагарина, 28', '9283000004');

INSERT INTO `otk`.`services` (`id`, `name`, `price`) VALUES ('10', 'Проверка на загрязнение окна', '100');
INSERT INTO `otk`.`services` (`id`, `name`, `price`) VALUES ('20', 'Проверка окна на гермитичность', '200');

INSERT INTO `otk`.`users` (`login`, `customerId`,`roleCode`, `name`, `password`) VALUES ('admin', '1','manager', 'Иванов Максим', '1');
INSERT INTO `otk`.`users` (`login`, `customerId`, `roleCode`, `name`, `password`) VALUES ('roma', '2', 'client', 'Роман Александрович', '1');

INSERT INTO `otk`.`orders` (`userLogin`, `serviceId`, `discountPercent`) VALUES ('roma', '10', '0');
INSERT INTO `otk`.`orders` (`userLogin`, `serviceId`, `discountPercent`) VALUES ('roma', '20', '10');
INSERT INTO `otk`.`orders` (`userLogin`, `serviceId`, `discountPercent`) VALUES ('admin', '10', '0');
