﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cabanas.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabanas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabanas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cabanas",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { 1, "Aut. San Isidro", 18.4895593, -69.824781900000005, "Oriental" },
                    { 137, "Av. Padre Abreu Esq. Pedro A. Lluberes", 18.432724, -68.970692, "Hotel Olimpo" },
                    { 138, "Carretera La Romana - Bayahibe Km 13", 18.438549999999999, -68.867802999999995, "Hotel Vecchia Caserma" },
                    { 139, "Carretera Higüey - Yuma Km. 1", 18.592863999999999, -68.716960999999998, " K&C Gran Hotel" },
                    { 140, "Carretera Higuey-Yuma", 18.431927000000002, -68.687400999999994, "Mi Tesoro" },
                    { 141, "Calle Principal", 18.369828999999999, -68.839256000000006, "Hotel Bayahibe" },
                    { 142, "Ave EE UU  C/Guarionex 3", 18.687815000000001, -68.454255000000003, " Guesthouse Las Piedras" },
                    { 143, "Carretera Punta Cana a 300m", 18.604693000000001, -68.483042999999995, "Aparta Hotel Veron" },
                    { 144, "Carretera de Veron-Punta Cana km 31", 18.597024999999999, -68.438193999999996, "Hotel Yonu" },
                    { 145, "Carretera Higuey Punta Cana Km 31", 18.596540999999998, -68.444218000000006, "Hotel Restaurant El Bosque" },
                    { 146, "Residencial Villas Bávaro  Avenida del Bosque", 18.667750000000002, -68.412332000000006, "Apartamentos Villa Elena" },
                    { 136, "Calle Central 79", 18.416132000000001, -69.469695999999999, "Pensión Lucirooms" },
                    { 147, "Avenida Italia", 18.692194000000001, -68.440276999999995, "Hotel Flamboyan" },
                    { 149, "Carretera Veron Km 36", 18.594697, -68.453390999999996, "Hotel El Viajante" },
                    { 150, "Principe de Los Corales  14", 18.700220999999999, -68.449512999999996, "Hostel Punta Cana" },
                    { 151, "Av. Alemania", 18.682006000000001, -68.413033999999996, "Apartamento Bavaro Punta Cana El Dorado" },
                    { 152, "Carretera Verón Punta Cana Km 48", 18.58324, -68.398071000000002, " Hotel Plaza Coral" },
                    { 153, "Las Terrenas", 19.321743999999999, -69.535893000000002, "Hotel Casa Robinson" },
                    { 154, "Boca de Mao", 19.586743999999999, -71.033572000000007, "Cabañas Bernard" },
                    { 155, "Boca de Mao", 19.585522000000001, -71.028559000000001, "Cabañas Monte Bello" },
                    { 156, "Polo  Barahona", 18.115409220969301, -71.273741837921094, "El Rancho Lembert" },
                    { 157, "San Juan ", 18.864709999999999, -71.367189999999994, "Hotel alegria" },
                    { 158, "", 18.521148, -70.010689999999997, "Hotel El Encuentro" },
                    { 148, "Los Corales", 18.684121999999999, -68.416499999999999, "Bavaro Hostel" },
                    { 135, "Juan Dolio", 18.426687999999999, -69.416025000000005, "Hotel Fior Di Loto" },
                    { 134, "Guayacanes", 18.418574, -69.458357000000007, "Apartamentos OASIS" },
                    { 133, "Malecon San Pedro", 18.440550999999999, -69.309973999999997, " Hotel Escuela Macorix" },
                    { 110, "Av Doctor Fernando Arturo Defilló # 43", 18.457052000000001, -69.947284999999994, "Hotel Bella Vista" },
                    { 111, "Abraham Lincoln #116", 18.455646999999999, -69.924854999999994, " Hotel Royal Palace" },
                    { 112, "Calle Dr. Heriberto Pieter No.34  Ensanche Naco", 18.481586, -69.927802, "Hotel Aladino" },
                    { 113, "Av. Independencia #45  Gazcue", 18.468387, -69.894406000000004, "Hotel-Residence Venezia" },
                    { 114, "Calle La Danae No. 18  Gazcue", 18.467873000000001, -69.897242000000006, "Hotel La Danae" },
                    { 115, "Calle Arzobispo Meriño #111", 18.473769999999998, -69.884462999999997, "Hotel Conde de Peñalba" },
                    { 116, "Calle Duarte 106  Ciudad Colonial", 18.473738999999998, -69.886275999999995, " Boutique Hotel Palacio" },
                    { 117, "Arismendy Valenzuela 2", 18.451426000000001, -69.607816, "Hotel Mango" },
                    { 118, "Calle Abraham Nuñez #27", 18.447241999999999, -69.608624000000006, "Hotel Zapata" },
                    { 119, "Calle Duarte #17", 18.448513999999999, -69.599418999999997, "Hotel Neptuno" },
                    { 120, "Calle San Rafael  # 18", 18.448331, -69.613347000000005, "Apart-Hotel Parco Del Caribe" },
                    { 121, "Calle 20 de Diciembre #5", 18.44952, -69.606769999999997, "Hotel El Gaucho" },
                    { 122, "Calle Dominguez  #8", 18.448058, -69.608275000000006, "Hotel Casa Coco" },
                    { 123, "Calle Don Antonio Guzman No. 3", 19.230879928865701, -70.530410371720706, "Hotel el Rey" },
                    { 124, "Aut. Duarte", 18.967600300000001, -70.413584099999994, "Hotel Jacaranda" },
                    { 125, "Cesar Nicolas Penson Gazcue", 18.472451629773399, -69.897692017257199, "Carey House Hotel" },
                    { 126, "Las Terrenas", 19.306939395355201, -69.555738684120101, "Monaco Cottage" },
                    { 127, "Los Tres Ojos", 18.482634000000001, -69.846737000000005, "Cabañas Villa España" },
                    { 128, "Ave Juan Pablo Duarte", 18.494551938272, -69.900460056960497, "Hotel Cabañas Presidente" },
                    { 129, "Calle Santa Barbara", 19.203859000000001, -69.332436000000001, "Casa de huespedes Mildania" },
                    { 130, "Calle Duarte", 19.204855999999999, -69.333596, "DOCIA BLACKPAKERS" },
                    { 131, "C/ Francisco del Rosario Sanchez", 19.203838000000001, -69.339260999999993, "Hotel Leidy" },
                    { 132, "Ave Circunvalacion", 19.203814999999999, -69.338133999999997, "Hotel Cotubanama" },
                    { 159, "ave. Albert Thomas # 264", 18.504322582535799, -69.896680489182401, "Hotel Noche de Travesuras" },
                    { 160, "", 18.256879000000001, -70.285514000000006, "Cabañas Tentacion" },
                    { 161, "", 18.462511572155801, -69.975928030908094, "Hotel Cima" },
                    { 162, "Dr A Martínez 1  Sosua", 19.766349999999999, -70.516530000000003, " Hotel Casa Marina Beach Resort" },
                    { 190, "Av Las Américas Km 10", 18.466047, -69.821235000000001, "Gran Bahamas Hotel & Cabañas" },
                    { 191, "J I Reyes 65", 19.557929999999999, -71.077545999999998, "Hotel Cabaña San Roque" },
                    { 192, "Carr Palenque 38", 18.288038, -70.124531000000005, "Cabañas Las Colinas Del Placer" },
                    { 193, "Aut 30 de Mayo 12", 18.424544999999998, -69.989900000000006, "Cabañas Madrid" },
                    { 194, "Av Cnel R T F Dguez 1 Km 2 1/2", 18.491056, -69.820379000000003, "Cabañas Miami" },
                    { 195, "Carr S F V Tapia 30", 19.308399000000001, -70.286226999999997, "Cabañas Sabel" },
                    { 196, "Aut San Isidro 1", 18.488672999999999, -69.823254000000006, "Cabañas Sol y Luna" },
                    { 197, "", 19.445101999999999, -70.667468, "Cabañas Turísticas La Alborada" },
                    { 198, "", 18.8903, -70.297399999999996, "Cabañas Turísticas La Grandiosa" },
                    { 199, "Carr Las Guarañas Km 3 1/2", 19.262809000000001, -70.221090000000004, "Cabañas Turisticas Rubi" },
                    { 200, "S Antonio 2", 18.590152, -69.840226999999999, "Hotel El Encuentro" },
                    { 201, "Anacaona 13", 18.206696999999998, -71.106859999999998, "Hotel Las Magnolias" },
                    { 202, "Av Anacaona Nte 94", 18.810300000000002, -71.231300000000005, "Hotel Medina" },
                    { 203, "", 18.811026999999999, -71.230838000000006, "Hotel La Gran Posada" },
                    { 204, "", 18.806403, -71.233583999999993, "Hotel Boutique El Espia" },
                    { 205, "", 18.806642, -71.225590999999994, "Hotel Maguana" },
                    { 206, "", 18.517099999999999, -69.807199999999995, "Hotel Pasión De Luna" },
                    { 207, "S Antonio 2", 18.590152, -69.840226999999999, "Hotel Poderoso" },
                    { 208, "A Meriño 31", 18.762640000000001, -69.034615000000002, "Motel Julling" },
                    { 209, "Aut Duarte km 5 1/2", 19.418991999999999, -70.647807999999998, "Moteles Imperiales" },
                    { 210, "Libertad 13", 19.321023, -69.540407000000002, "Paco Cabaña" },
                    { 211, "", 19.321341, -69.538874000000007, "Residencia Del Paseo" },
                    { 212, "", 19.322462999999999, -69.541967, "Condo Hotel Caribey" },
                    { 189, "Carr F Basilis 20", 19.100667999999999, -70.654642999999993, "De La Montaña Cabañas Turísticas" },
                    { 109, "Calle Danae #35  Gazcue", 18.468426999999998, -69.897639999999996, " Hotel Riparbella" },
                    { 188, "Carr G las Guáranas 1", 19.214804000000001, -70.058183999999997, "Centro Turístico Girasoles" },
                    { 186, "Carr San Fco-Tenares 12", 19.325167, -70.278486000000001, "Carolina High Aparta Hotel" },
                    { 163, "Carr Puerto Plata - Navarrete", 19.812034000000001, -70.730485000000002, "Aparta Hotel Sensación" },
                    { 164, "Car Limonal Abajo Km 7 1/2", 19.417732000000001, -70.646879999999996, "Olympus Cabañas Turísticas" },
                    { 165, "Car Romana - S Pedro Km 6", 18.444291, -69.041272000000006, "Cabañas Turísticas Tu y Yo" },
                    { 166, " R Cáceres 1  Coroso", 19.386801999999999, -70.532399999999996, "Cabañas Turísticas Las Nubes" },
                    { 167, "Car La Romana - Higuey ", 18.4241362, -68.946928900000003, "Casa de Campo Hotel" },
                    { 168, "Car San Fco - Tenares 12", 19.325865, -70.278323, "Anubys Cabañas Turísticas" },
                    { 169, "Aut 30 de Mayo 12", 18.443899999999999, -69.927099999999996, "Bellamar Hotel Y Restaurant" },
                    { 170, "Car Padre Billini 1", 18.549613000000001, -70.501231000000004, "Cabaña Villa Ensueño" },
                    { 171, "Aut 6 de Noviembre 1", 18.397106000000001, -70.144323, "Cabañas Cine" },
                    { 172, "Aut 6 de Noviembre 1  San Cristóbal", 18.443180000000002, -69.965800000000002, "Cabañas Cine SD" },
                    { 173, "Car Mella 1", 18.620284999999999, -68.726163999999997, "Cabañas Cristal" },
                    { 174, "Av 6 de Noviembre 10", 18.430342, -70.099157000000005, "Cabañas De Amor" },
                    { 175, "Car Guiza-Las Guaranas 1", 19.205321000000001, -70.220489999999998, "Cabañas Eros" },
                    { 176, " Car Uvero Alto 1  Punta Cana ", 18.806797, -68.585114000000004, "Cabañas La Curva del Amor" },
                    { 177, "", 18.424427999999999, -69.992958000000002, "Cabañas California" },
                    { 178, "Av K Adenauer 11  Santo Domingo", 18.545435000000001, -69.900238999999999, "Cabañas Good" },
                    { 179, "Carr Duarte 1  Cotui", 19.466660000000001, -70.69999, "Cabañas Holy Day" },
                    { 180, "San Francisco de Macorís", 19.307600000000001, -70.281800000000004, "Cabañas La Macorisana" },
                    { 181, "Carr Duarte Km 3  Santiago", 19.428108000000002, -70.654578000000001, "Cabañas Turisticas Sueños" },
                    { 182, " Aut Stgo Navarrete  Santiago", 19.491102999999999, -70.725161, "Cabañas Villa Hermosa" },
                    { 183, "Av E Unidos 5", 18.666169, -68.431177000000005, "Cabañas Vista Bávaro" },
                    { 184, "Carr Guáranas Km 13 1/2", 19.261800000000001, -70.221599999999995, "Cañabas Perla" },
                    { 185, "", 19.261780000000002, -70.219470000000001, "Cabañas Rebu" },
                    { 187, "Av Pdte A G Fernández 1", 19.287306999999998, -70.271214999999998, "Casa Dorada" },
                    { 108, "Ave. Independencia No. 304  Gazcue", 18.465494, -69.896879999999996, "Hotel Duque de Wellington" },
                    { 107, "Calle Arzobispo Nouel #402", 18.470904000000001, -69.891121999999996, "Hotel Discovery" },
                    { 106, "", 19.306000000000001, -69.562780000000004, "Residencia Hotel Madrugada" },
                    { 29, "Aut. 30 de Mayo  KM 12", 18.425150800000001, -69.990352099999996, "Costa azul" },
                    { 30, "Aut. 30 de Mayo  KM 12", 18.426400000000001, -69.991174400000006, "Si o No" },
                    { 31, "Aut. 30 de Mayo  KM 12", 18.425093, -69.992578300000005, "Yes" },
                    { 32, "Aut. 30 de Mayo  KM 12", 18.425558899999999, -69.9937288, "Kiss" },
                    { 33, "Aut. 30 de Mayo  KM 12", 18.424954400000001, -69.993766800000003, "La uni" },
                    { 34, "Aut. 30 de Mayo  KM 12", 18.424263, -69.992290199999999, "Tia Tania" },
                    { 35, "Aut. 30 de Mayo  KM 12", 18.424177199999999, -69.991686400000006, "Honey moon" },
                    { 36, "Aut. 30 de Mayo  KM 12", 18.423432699999999, -69.990826400000003, "Chevere" },
                    { 37, "Aut. 30 de Mayo  KM 12", 18.423709800000001, -69.990465900000004, "Okey" },
                    { 38, "Calle Juan A Vicioso  Sto Dgo", 18.4281617, -69.968924400000006, "Queen" },
                    { 39, "Calle 32 Felix Evaristo Mejia", 18.4945129, -69.909946399999995, "Cabañas el Príncipe" },
                    { 40, "Ave. Pedro Livio Cedeño", 18.496143499999999, -69.913885300000004, "Cabañas La Playa" },
                    { 41, "Aut. San Isidro", 18.4901968, -69.821542399999998, "La Oficina" },
                    { 42, "Calle Americo Lugo", 18.490216700000001, -69.915892900000003, "Hotel Fiesta" },
                    { 43, "Calle Mauricio Baez", 18.488173700000001, -69.915096899999995, "Hotel cabañas Isla de Oro" },
                    { 44, "Ave. Nicolas de Ovando", 18.500178099999999, -69.910271100000003, "Hotel cabañas Sol de Verano" },
                    { 45, "Ave. Nicolas de Ovando", 18.500156700000002, -69.911650899999998, "Hotel cabañas Lincoln" },
                    { 46, "Calle 28 Anibal de Espinosa", 18.496359999999999, -69.909606600000004, "Cabaña Hotel Latino" },
                    { 47, "Calle 28 Anibal de Espinosa", 18.489732199999999, -69.917253299999999, "Cabañas Hotel 8" },
                    { 48, "Ensanche la Fe", 18.497231500000002, -69.921933100000004, "Cabañas el mundo del Amor" },
                    { 49, "Calle San Juan de la Maguana", 18.5017274, -69.912822899999995, "Cabañas Hotel Internacional" },
                    { 50, "Av. Hermanas Mirabal  Villa Mella", 18.527448799999998, -69.915571999999997, "Cabañas el Bonche" },
                    { 51, "Calle Ramon Matias Mella  Villa Mella", 18.550612900000001, -69.900295900000003, "Cabañas Monte Bonito" },
                    { 28, "Aut. 30 de Mayo  KM 12", 18.424664400000001, -69.990071, "Love" },
                    { 52, "Ave. Charles de Gaulle  Villa Mella", 18.545226599999999, -69.897776399999998, "Cabañas hotel Super" },
                    { 27, "Aut. 30 de Mayo  KM 12", 18.424518200000001, -69.989915499999995, "Mister" },
                    { 25, "Aut. Duarte KM 11 y 1/2", 18.498591600000001, -69.992406000000003, "Villa campo" },
                    { 2, "Aut. San Isidro", 18.489203100000001, -69.824170100000003, "Alli" },
                    { 3, "Aut. San Isidro", 18.487943999999999, -69.822770000000006, "Aki" },
                    { 4, "Aut. San Isidro", 18.490191100000001, -69.822606399999998, "Cabañas Presidente" },
                    { 5, "Aut. San Isidro", 18.4897408, -69.822398800000002, "Extasis" },
                    { 6, "Aut. San Isidro", 18.4897809, -69.822173199999995, "Cariño" },
                    { 7, "Aut. San Isidro", 18.489488699999999, -69.8209564, "La compañia" },
                    { 8, "Aut. San Isidro", 18.489893800000001, -69.820286199999998, "yeah" },
                    { 9, "Aut. San Isidro", 18.490419800000002, -69.819985000000003, "Happy City" },
                    { 10, "Aut. San Isidro", 18.489663700000001, -69.819548900000001, "El jardin" },
                    { 11, "Aut. San Isidro", 18.490367500000001, -69.818503800000002, "Universal" },
                    { 12, "Aut. San Isidro", 18.4903327, -69.817480000000003, "Obssetion" },
                    { 13, "Aut. San Isidro", 18.490558100000001, -69.817541700000007, "Ta jevy" },
                    { 14, "Aut. San Isidro", 18.491107800000002, -69.822627400000002, "Miami" },
                    { 15, "Aut. San Isidro", 18.490600199999999, -69.822997599999994, "Scape" },
                    { 16, "Aut. San Isidro", 18.490784999999999, -69.823844100000002, "Cabañas del Caribe" },
                    { 17, "Ave. Los Beisbolistas  Manoguayabo", 18.448696699999999, -69.981779299999999, "Nuevo mundo" },
                    { 18, "Ave. Los Beisbolistas  Manoguayabo", 18.484442699999999, -69.984988299999998, "Popular" },
                    { 19, "Ave. Los Beisbolistas  Manoguayabo", 18.484038399999999, -69.984555900000004, "Nuevo milenio" },
                    { 20, "Ave. Los Beisbolistas  Manoguayabo", 18.483819700000002, -69.9797394, "Manhattan" },
                    { 21, "Ave. Los Beisbolistas  Manoguayabo", 18.484345399999999, -69.978920200000005, "Ciudad de oro" },
                    { 22, "Ave. Los Beisbolistas  Manoguayabo", 18.484638199999999, -69.978840399999996, "Motel florida" },
                    { 23, "Ave. Los Beisbolistas  Manoguayabo", 18.484196600000001, -69.982178200000007, "Primavera" },
                    { 24, "Aut. Duarte KM 11 y 1/2", 18.498299299999999, -69.991755499999996, "Ciudad corazón" },
                    { 26, "Aut. 30 de Mayo  KM 12", 18.424459299999999, -69.989453100000006, "Bayamesa" },
                    { 213, "", 19.318985000000001, -69.540745000000001, "Hotel Piedra Marron" },
                    { 53, "Ave. Charles de Gaulle  Villa Mella", 18.5472231, -69.890065699999994, "Cabañas Horny" },
                    { 55, "Ave. Charles de Gaulle  Sabana Perdida", 18.541952299999998, -69.856220899999997, "Cabañas Preciosa" },
                    { 83, "Aut. Duarte  La Vega", 19.2750618, -70.570166900000004, "Cabañas Paraiso" },
                    { 84, "Aut. Duarte  La Vega", 19.317617899999998, -70.586611700000006, "Cabañas Jupiter" },
                    { 85, "La Vega", 19.363647700000001, -70.603590499999996, "Cabañas Villa Bella" },
                    { 86, "Aut. Duarte  La Vega", 19.218302999999999, -70.496960700000002, "Cabañas Turísticas Atlas" },
                    { 87, "Aut. Duarte  Bonao", 18.932262999999999, -70.387951999999999, "Cabañas las Palmas" },
                    { 88, "Aut. Duarte  Bonao", 18.932125500000001, -70.386364299999997, "Cabañas La Fuente del Placer" },
                    { 89, "Aut. Duarte  Piedra Blanca", 18.8575911, -70.342830399999997, "Cabañas Heaven" },
                    { 90, "Aut. Joaquin Balaguer  Santiago", 19.502274400000001, -70.746448200000003, "Cabañas aparta hotel Ibiza" },
                    { 91, "Santiago De Los Caballeros", 19.5036901, -70.746107699999996, "Cabañas Turísticas Blue Castle" },
                    { 92, "Santiago De Los Caballeros", 19.416379899999999, -70.639911600000005, "Cabañas Zeus" },
                    { 93, "Santiago De Los Caballeros", 19.505016399999999, -70.745878300000001, "Cabañas Poseidon" },
                    { 94, "Santiago De Los Caballeros", 19.5067892, -70.745694400000005, "Cabañas Venus VIP" },
                    { 95, "Circunvalacion Norte  Villa Gonzalez  Santiago ", 19.5195331, -70.762640399999995, "Cabañas Mirage" },
                    { 96, "Higuey La Otra Banda  km 1.5", 18.644299400000001, -68.695265300000003, "Cabañas Copa Caribe" },
                    { 97, "Ave. San Martín No.198  Ens. La Fé", 18.4845778662322, -69.915845207870007, "Hotel Restaurant Londres" },
                    { 98, "Ave. de las Hortensias", 18.952211533885102, -70.402122996747394, "Bonao Inn" },
                    { 99, "Ave. de las Hortensias", 18.944216598557901, -70.397710762917896, "Hermes Aparta Hotel" },
                    { 100, "Av. Jose Contreras", 18.460311999999998, -69.923944000000006, "Hotel José Contreras" },
                    { 101, "Aut. San Isidro", 18.489675946200201, -69.823696576058794, "Malibu" },
                    { 102, "La Vega", 19.203004756713799, -70.494820140302096, "Aparta Hotel Los Pinos" },
                    { 103, "Av. Presidente Antonio Guzman F.", 19.440600817660599, -70.724938586354199, "View Aparta Hotel" },
                    { 104, "Aut. 6 de Noviembre", 18.40457, -70.137540000000001, "Cabañas Cupido" },
                    { 105, "", 18.464224736381201, -69.895942211151095, "Hotel Maison Gautreaux" },
                    { 82, "Aut. Duarte  La Vega", 19.2539646, -70.562802899999994, "Cabañas Turísticas La Vega Real" },
                    { 54, "Ave. Charles de Gaulle  Sabana Perdida", 18.540917799999999, -69.855176599999993, "Cabañas Hoy" },
                    { 81, "La Vega", 19.2417488, -70.525228400000003, "Cabañas aparta hotel Galaxy" },
                    { 79, "Ave. San Vicente de Paul", 18.4943937, -69.851396300000005, "Cabañas Diamante Azul" },
                    { 56, "Ave. Charles de Gaulle  Zona Horiental", 18.535277099999998, -69.847774599999994, "Cabañas la Paz" },
                    { 57, "Marginal de las Americas", 18.4670822, -69.820685900000001, "Cabañas Miramar" },
                    { 58, "Marginal de las Americas", 18.466696899999999, -69.793395899999993, "Cabañas Son" },
                    { 59, "Ave. 27 de Febrero  Santo Domingo", 18.4508808, -69.963961900000001, "Cabañas Centrun" },
                    { 60, "Ave. Isabel Aguiar  Sto Dgo.", 18.468564000000001, -69.973697000000001, "Cabañas Ahora" },
                    { 61, "Ave. Isabel Aguiar  Santo Domingo", 18.471416699999999, -69.972385000000003, "Cabañas Hotel Roma" },
                    { 62, "Ave. Isabel Aguiar  Santo Domingo", 18.4733415, -69.971580399999993, "Hotel Cabañas Mi Cam Cam" },
                    { 63, " Aut. Duarte  Santiago De Los Caballeros", 19.4247288, -70.6478927, "Cabañas Turistica Eclipse" },
                    { 64, "Aut. Duarte  Santiago De Los Caballeros", 19.4202428, -70.648786700000002, "Bora Bora Aparta Hotel" },
                    { 65, "Santiago De Los Caballeros", 19.415979, -70.646714599999996, "Cabañas Venus" },
                    { 66, "Santiago De Los Caballeros", 19.4200141, -70.648353099999994, "Helios Aparta Hotel" },
                    { 67, "Santiago De Los Caballeros", 19.411484699999999, -70.639889699999998, "Cabañas Turisticas Ethics" },
                    { 68, "Carretera Las Palomas  Santiago De Los Caballeros", 19.426135200000001, -70.648783899999998, "Moteles El Arco" },
                    { 69, "Carretera Sabaneta  Las Palomas ", 19.426135200000001, -70.651370400000005, "Horus Aparta Hotel" },
                    { 70, "Santiago De Los Caballeros", 19.443836600000001, -70.667987999999994, "Cabañas Villas del Sol" },
                    { 71, " Carretera Las Palomas  Santiago ", 19.425567099999999, -70.651206200000004, "Cabañas Imperial" },
                    { 72, "Santiago De Los Caballeros", 19.4197816, -70.6512666, "Moteles el Palmar" },
                    { 73, " Santiago De Los Caballeros", 19.445165299999999, -70.667007600000005, "Moteles Venus " },
                    { 74, "Santiago De Los Caballeros", 19.450054000000002, -70.665332800000002, "Cabañas aparta Hotel Pegasus" },
                    { 75, "Santiago De Los Caballeros", 19.449765200000002, -70.665608500000005, "Cabañas Turísticas Afrodita" },
                    { 76, "Santiago De Los Caballeros", 19.500501, -70.741505399999994, "Cabañas Elysium" },
                    { 77, "Aut. Las Americas ", 18.4855704, -69.867223300000006, "Hotel Cabañas Reunion" },
                    { 78, "Ave. San Vincente de Paul", 18.510334499999999, -69.874488099999994, "Cabañas Hotel La Cita" },
                    { 80, "Ave. San Vicente de Paul", 18.4962871, -69.851527099999998, "Cabañas Hotel El Crucero" },
                    { 214, "Carr Pto Pta-Stgo Km 2", 19.712177000000001, -70.622879999999995, "Super Cabañas Hollywood" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cabanas");
        }
    }
}
