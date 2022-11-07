// Proyecto de algoritmos y estructuras de datos
// Usar la librería de clases
using LibreriaClases;
// Librería para poder usar ArrayList
using System.Collections;
// Declarar el ArrayList que contendrá todos los clientes de la app
ArrayList Clientes = new();
#region LOS 20 CLIENTES POR DEFECTO
Clientes.Add(new CCliente("95961212", "Elías Vicente Carballo", "3467 Tawny Terrace"));
Clientes.Add(new CCliente("36192134", "Marcos Gras Lastra", "837 Middle Diversion"));
Clientes.Add(new CCliente("85586251", "Marcial Rivero Grau", "4430 Quaking Anchor Ramp"));
Clientes.Add(new CCliente("85143178", "Jose Francisco Jáuregui Cortés", "6913 Golden Cider Park"));
Clientes.Add(new CCliente("45686143", "Ofelia Zabaleta Miralles", "7712 Jagged Pine Passage"));
Clientes.Add(new CCliente("82784817", "África Soledad Ruiz Piñol", "3302 Colonial Dale Meadow"));
Clientes.Add(new CCliente("01278535", "Erasmo Mauricio Ortuño Ordóñez", "8773 Clear View"));
Clientes.Add(new CCliente("34480959", "Cristian Herrero Puente", "9306 Amber Inlet"));
Clientes.Add(new CCliente("05196068", "Eustaquio Yáñez-Ballesteros", "750 Cotton Highway"));
Clientes.Add(new CCliente("97218107", "Joaquina Milagros Zamora Saez", "3775 Cinder Autoroute"));
Clientes.Add(new CCliente("64093986", "Alejandra Jove Calleja", "9947 Little Range"));
Clientes.Add(new CCliente("90773924", "Amelia Casandra Vizcaíno Amat", "8896 Grand Shadow Farm"));
Clientes.Add(new CCliente("26620115", "Javier Pedro Azcona", "3989 Burning Falls"));
Clientes.Add(new CCliente("50343623", "Juan Francisco Robles Escalona", "8592 Honey Timber Woods"));
Clientes.Add(new CCliente("11423917", "Jacobo de Perera", "5299 High End"));
Clientes.Add(new CCliente("67432981", "María José Villena Pinedo", "4942 Harvest Apple Plaza"));
Clientes.Add(new CCliente("55852593", "Hortensia Elena Barco Palma", "98 Emerald Lane"));
Clientes.Add(new CCliente("42691085", "Osvaldo Menéndez Alcalá", "8796 Pleasant Arbor"));
Clientes.Add(new CCliente("072516", "Jose Francisco Galvez Alberola", "8011 Blue Grove Highlands"));
Clientes.Add(new CCliente("226717", "Leyre Romero Carrión", "7686 Dusty Corner"));
#endregion

ArrayList Productos = new();
#region LOS 22 PRODCTOS POR DEFECTO
Productos.Add(new CProducto("0103", "Leche en tarro Gloria", "Lacteo", "ml", 17, 3.5));
Productos.Add(new CProducto("0204", "Leche en tarro Ideal ", "Lacteo", "ml", 17, 3.9));
Productos.Add(new CProducto("0305", "Leche en tarro Prua Vida", "Lacteo", "ml", 17, 3.9));
Productos.Add(new CProducto("0406", "Legia Opal 350g", "Detergente", "g", 13, 4.5));
Productos.Add(new CProducto("0507", "Legia Opal 700g", "Detergente", "g", 10, 9.0));
Productos.Add(new CProducto("0608", "Legia Marsella 350g", "Detergente", "g", 13, 4));
Productos.Add(new CProducto("0709", "Legia Ace 350g", "Detergente", "g", 13, 4.3));
Productos.Add(new CProducto("0810", "Legia Ptito 120g", "Detergente", "g", 13, 1.5));
Productos.Add(new CProducto("0911", "Fideos Nicolini carobatita", "Fideos", "g", 17, 1.5));
Productos.Add(new CProducto("1012", "Fideos Nicolini codo chico", "Fideos", "g", 17, 1.5));
Productos.Add(new CProducto("1113", "Fideos Nicolini codo", "Fideos", "g", 17, 1.5));
Productos.Add(new CProducto("1214", "Fideos Nicolini tornillo", "Fideos", "g", 17, 1.5));
Productos.Add(new CProducto("1315", "Fideos Don Vitorio Espagueti", "Fideos", "g", 17, 2.5));
Productos.Add(new CProducto("1416", "Fideos Don Vitorio Carballo de Angel", "Fideos", "g", 17, 2.3));
Productos.Add(new CProducto("1517", "Gaseosa Inka Cola 1 litro", "Vevidas gasificadas", "ml", 15, 6.0));
Productos.Add(new CProducto("1618", "Gaseosa Inka Cola 2 litro", "Vevidas gasificadas", "ml", 15, 12.0));
Productos.Add(new CProducto("1719", "Gaseosa Coca Cola 1 litro", "Vevidas gasificadas", "ml", 15, 6.0));
Productos.Add(new CProducto("1820", "Gaseosa Coca Cola 2 litro", "Vevidas gasificadas", "ml", 15, 12.0));
Productos.Add(new CProducto("1921", "Gaseosa Kola Real 1 litro", "Vevidas gasificadas", "ml", 15, 5.0));
Productos.Add(new CProducto("2022", "Gaseosa Inka Real 2 litro", "Vevidas gasificadas", "ml", 15, 10.0));
#endregion

ArrayList RegistroVentas = new();   
#region LOS 22 PRODCTOS POR DEFECTO
RegistroVentas.Add(new CRegistroVentas("91035", "00001", "12/05/2022", "95961212", "0101", 1, 3.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("92036", "00002", "12/04/2022", "36192134", "0202", 1, 3.9, Clientes));
RegistroVentas.Add(new CRegistroVentas("93036", "00003", "11/04/2022", "85586251", "0303", 1, 3.9, Clientes));
RegistroVentas.Add(new CRegistroVentas("94036", "00004", "10/04/2022", "85143178", "0404", 1, 4.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("95036", "00005", "11/03/2022", "45686143", "0505", 1, 9.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("96036", "00006", "11/03/2022", "82784817", "0606", 1, 4.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("97036", "00007", "12/04/2022", "01278535", "0707", 1, 4.3, Clientes));
RegistroVentas.Add(new CRegistroVentas("98036", "00008", "12/05/2022", "34480959", "0808", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("99036", "00009", "10/05/2022", "05196068", "0909", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("81736", "00010", "12/05/2022", "97218107", "1010", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("82736", "00011", "12/05/2021", "64093986", "0101", 1, 3.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("83736", "00012", "12/04/2021", "90773924", "0202", 1, 3.9, Clientes));
RegistroVentas.Add(new CRegistroVentas("84736", "00013", "11/04/2021", "26620115", "0303", 1, 3.9, Clientes));
RegistroVentas.Add(new CRegistroVentas("85736", "00014", "10/04/2021", "50343623", "0404", 1, 4.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("86736", "00015", "11/03/2021", "11423917", "0505", 1, 9.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("87736", "00016", "11/03/2021", "67432981", "0606", 1, 4.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("88736", "00017", "12/04/2021", "55852593", "0707", 1, 4.3, Clientes));
RegistroVentas.Add(new CRegistroVentas("89736", "00018", "12/05/2021", "42691085", "0808", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("81736", "00019", "10/05/2021", "072516", "0909", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("72736", "00020", "12/05/2021", "226717", "1010", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("73736", "00021", "12/05/2020", "95961212", "1111", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("74736", "00022", "12/04/2020", "36192134", "1212", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("75736", "00023", "11/04/2020", "85586251", "1313", 1, 2.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("76736", "00024", "10/04/2020", "85143178", "1414", 1, 2.3, Clientes));
RegistroVentas.Add(new CRegistroVentas("77736", "00025", "11/03/2020", "45686143", "1515", 1, 6.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("78736", "00026", "11/03/2020", "82784817", "1616", 1, 12.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("79736", "00027", "12/04/2020", "01278535", "1717", 1, 6.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("71736", "00028", "12/05/2021", "34480959", "1818", 1, 12.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("72736", "00029", "10/05/2020", "05196068", "1919", 1, 5.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("63736", "00030", "12/05/2020", "97218107", "2020", 1, 10.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("64736", "00031", "02/05/2020", "64093986", "1111", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("65736", "00032", "02/04/2020", "90773924", "1212", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("66736", "00033", "01/04/2021", "26620115", "1313", 1, 2.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("67736", "00034", "00/04/2020", "50343623", "1414", 1, 2.3, Clientes));
RegistroVentas.Add(new CRegistroVentas("68736", "00035", "01/03/2020", "11423917", "1515", 1, 6.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("69736", "00036", "01/03/2022", "67432981", "1616", 1, 12.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("61736", "00037", "02/04/2020", "55852593", "1717", 1, 6.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("62736", "00038", "02/05/2022", "42691085", "1818", 1, 12.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("63736", "00039", "00/05/2020", "072516", "1919", 1, 5.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("54736", "00040", "02/05/2021", "226717", "2020", 1, 10.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("55736", "00051", "12/03/2020", "95961212", "0202", 1, 3.9, Clientes));
RegistroVentas.Add(new CRegistroVentas("56736", "00052", "12/02/2020", "36192134", "0303", 1, 3.9, Clientes));
RegistroVentas.Add(new CRegistroVentas("57736", "00053", "11/02/2021", "85586251", "0404", 1, 4.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("58736", "00054", "10/02/2020", "85143178", "0505", 1, 9.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("59736", "00055", "11/01/2020", "45686143", "0606", 1, 4.0, Clientes));
RegistroVentas.Add(new CRegistroVentas("51736", "00056", "11/01/2022", "82784817", "0707", 1, 4.3, Clientes));
RegistroVentas.Add(new CRegistroVentas("52736", "00057", "12/02/2020", "01278535", "0808", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("53736", "00058", "12/03/2022", "34480959", "0909", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("54736", "00059", "10/03/2020", "05196068", "1010", 1, 1.5, Clientes));
RegistroVentas.Add(new CRegistroVentas("55736", "00060", "12/03/2021", "97218107", "1111", 1, 1.5, Clientes));
#endregion


CMenu.MostrarMenu(Clientes, Productos, RegistroVentas);