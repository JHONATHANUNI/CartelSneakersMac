namespace UrbanKicksMac;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Brand { get; set; } = "";
    public decimal Price { get; set; }
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public string ImageUrl2 { get; set; } = "";
}

public class CartItem
{
    public int ProductId { get; set; }
    public string Name { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public string Size { get; set; } = "";
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public decimal Total => UnitPrice * Quantity;
}

public static class ProductCatalog
{
    private static readonly List<Product> Products =
    [
        new() { Id = 1, Name = "LV Trainer Black & White Monogram", Brand = "Louis Vuitton", Price = 159900, Description = "Iconic low-top sneaker featuring black and white monogram denim panels and embossed detailing.", ImageUrl = "390M.jpg", ImageUrl2 = "390M.jpg" },
        new() { Id = 2, Name = "LV Skate Sneaker All-Black Rhinestone", Brand = "Louis Vuitton", Price = 159900, Description = "Chunky skate-inspired silhouette in full black with rhinestone embellishments and flower branding.", ImageUrl = "884M.jpg", ImageUrl2 = "884M.jpg" },
        new() { Id = 3, Name = "LV Skate Sneaker Triple Black", Brand = "Louis Vuitton", Price = 159900, Description = "Padded skate trainer with technical mesh, suede overlays, and signature lateral flower logo.", ImageUrl = "885M.jpg", ImageUrl2 = "885M.jpg" },
        new() { Id = 4, Name = "LV Trainer White Black Monogram", Brand = "Louis Vuitton", Price = 159900, Description = "Clean white leather basketball-inspired sneaker with subtle black trims and LV branding.", ImageUrl = "897M.jpg", ImageUrl2 = "897M.jpg" },
        new() { Id = 5, Name = "LV Trainer Beige & White Monogram", Brand = "Louis Vuitton", Price = 159900, Description = "Luxury low-top trainer designed in neutral beige denim accents over premium white leather.", ImageUrl = "898M.jpg", ImageUrl2 = "898M.jpg" },

        new() { Id = 6, Name = "Cloudmonster White & Pink", Brand = "On Cloud", Price = 159900, Description = "Zapatilla de amortiguación máxima con tecnología CloudTec en tono blanco con detalles rosa pastel.", ImageUrl = "12M.jpg", ImageUrl2 = "12M.jpg" },
        new() { Id = 7, Name = "Cloudmonster Navy Blue", Brand = "On Cloud", Price = 159900, Description = "Diseño de alto rendimiento para running y uso diario en azul marino con suela CloudTec blanca.", ImageUrl = "26M.jpg", ImageUrl2 = "26M.jpg" },
        new() { Id = 8, Name = "Cloudmonster Black & Mint", Brand = "On Cloud", Price = 159900, Description = "Silueta deportiva en malla transpirable color negro con sutiles acentos en verde menta.", ImageUrl = "30M.jpg", ImageUrl2 = "30M.jpg" },
        new() { Id = 9, Name = "Supermagma Off-White & Bronze", Brand = "Adidas", Price = 159900, Description = "Deportivo urbano con suela de máximo volumen en tono hueso con detalles bronce en el talón.", ImageUrl = "321M.jpg", ImageUrl2 = "321M.jpg" },
        new() { Id = 10, Name = "Cloudmonster White & Forest Green", Brand = "On Cloud", Price = 159900, Description = "Tenis ultraligeros en base blanca con elegantes detalles verde bosque y suela amortiguada.", ImageUrl = "535M.jpg", ImageUrl2 = "535M.jpg" },
        new() { Id = 11, Name = "Supernova Dreamstrike Cream & Orange", Brand = "Adidas", Price = 159900, Description = "Diseño de running moderno en tono crema con contornos naranja vibrante y suela gruesa.", ImageUrl = "633M.jpg", ImageUrl2 = "633M.jpg" },
        new() { Id = 12, Name = "Supernova Dreamstrike White & Light Blue", Brand = "Adidas", Price = 159900, Description = "Calzado deportivo de malla blanca ligera con las icónicas tres franjas en azul cielo.", ImageUrl = "635M.jpg", ImageUrl2 = "635M.jpg" },
        new() { Id = 13, Name = "Supernova Dreamstrike Black & White", Brand = "Adidas", Price = 159900, Description = "Estilo clásico deportivo en negro y blanco con tecnología de amortiguación Dreamstrike Glow.", ImageUrl = "640M.jpg", ImageUrl2 = "640M.jpg" },
        new() { Id = 14, Name = "LV Trainer Grey Monogram Denim", Brand = "Louis Vuitton", Price = 159900, Description = "Edición de lujo en cuero blanco y paneles de denim gris grabado con el patrón Monogram.", ImageUrl = "895A.jpg", ImageUrl2 = "895A.jpg" },

        new() { Id = 15, Name = "Go Run Max Cushioning Slip-Ins", Brand = "Skechers", Price = 159900, Description = "Zapatilla slip-on ultra cómoda en malla negra con suela alta perforada Max Cushioning.", ImageUrl = "918M.jpg", ImageUrl2 = "918M.jpg" },
        new() { Id = 16, Name = "LV Trainer Full Black Leather", Brand = "Louis Vuitton", Price = 159900, Description = "Diseño premium totalmente negro en cuero de alta calidad con cordones contrastantes y monograma grabado.", ImageUrl = "341A.jpg", ImageUrl2 = "341A.jpg" },
        new() { Id = 17, Name = "Air Jordan 1 Low Patent Black", Brand = "Nike", Price = 159900, Description = "Silueta clásica de perfil bajo confeccionada en charol negro brillante con costuras blancas acentuadas.", ImageUrl = "534A.jpg", ImageUrl2 = "534A.jpg" },
        new() { Id = 18, Name = "Supernova Dreamstrike Off-White & Black", Brand = "Adidas", Price = 159900, Description = "Calzado de running en tono crema claro con detalles en verde menta y las tres franjas en negro.", ImageUrl = "743M.jpg", ImageUrl2 = "743M.jpg" },
        new() { Id = 19, Name = "Air Force 1 Low Triple Black", Brand = "Nike", Price = 159900, Description = "El clásico de la cultura urbana en una versión totalmente negra de acabado mate y suela Air.", ImageUrl = "883M.jpg", ImageUrl2 = "883M.jpg" },
        new() { Id = 20, Name = "LV Trainer White & Black Classic", Brand = "Louis Vuitton", Price = 159900, Description = "Inspiración en el baloncesto retro con acabado en cuero blanco premium y detalles en negro.", ImageUrl = "894A.jpg", ImageUrl2 = "894A.jpg" },
        new() { Id = 21, Name = "Go Run Max Cushioning Dark Grey", Brand = "Skechers", Price = 159900, Description = "Zapatilla slip-in liviana en tejido mesh gris oscuro con suela de amortiguación Max Cushioning gris.", ImageUrl = "916M.jpg", ImageUrl2 = "916M.jpg" },
        new() { Id = 22, Name = "Go Run Max Cushioning Lavender", Brand = "Skechers", Price = 159900, Description = "Diseño deportivo de máximo confort en un llamativo color lavanda/púrpura con tecnología Glide-Step.", ImageUrl = "919M.jpg", ImageUrl2 = "919M.jpg" },
        new() { Id = 23, Name = "Go Run Max Cushioning Triple White", Brand = "Skechers", Price = 159900, Description = "Silueta ultraligera de entrenamiento en blanco total con malla respirable y ajuste sin cordones.", ImageUrl = "920M.jpg", ImageUrl2 = "920M.jpg" },
        new() { Id = 24, Name = "New Balance 740 Metallic Bronze", Brand = "New Balance", Price = 159900, Description = "Estilo retro-runner de los años 2000 con malla beige, superposiciones bronce metálico y amortiguación ABZORB.", ImageUrl = "4533.jpg", ImageUrl2 = "4533.jpg" },
        new() { Id = 26, Name = "Cloudmonster Dark Grey & White", Brand = "On Cloud", Price = 159900, Description = "Diseño de alto rendimiento en tono gris oscuro con suela gruesa CloudTec en contraste blanco.", ImageUrl = "7M.jpg", ImageUrl2 = "7M.jpg" },
        new() { Id = 27, Name = "Cloudmonster Sand & Berry", Brand = "On Cloud", Price = 159900, Description = "Silueta moderna en tono arena/beige con cordones en tono baya y suela CloudTec ultraligera.", ImageUrl = "294M.jpg", ImageUrl2 = "294M.jpg" },
        new() { Id = 28, Name = "Duramo Speed Navy & White", Brand = "Adidas", Price = 159900, Description = "Zapatilla de running ligera en azul marino con las tres franjas laterales en contraste blanco.", ImageUrl = "678A.jpg", ImageUrl2 = "678A.jpg" },
        new() { Id = 29, Name = "Duramo Speed Core Black", Brand = "Adidas", Price = 159900, Description = "Modelo deportivo en malla transpirable totalmente negra con detalles y suela en blanco puro.", ImageUrl = "679A.jpg", ImageUrl2 = "679A.jpg" },
        new() { Id = 30, Name = "Duramo Speed Black & Solar Orange", Brand = "Adidas", Price = 159900, Description = "Diseño dinámico en base negra con llamativos detalles y acentos en naranja vibrante.", ImageUrl = "892A.jpg", ImageUrl2 = "892A.jpg" },
        new() { Id = 31, Name = "Air Force 1 Low Black & Purple Stitch", Brand = "Nike", Price = 159900, Description = "Edición especial en cuero negro con costuras blancas acentuadas, forro interno morado y swoosh de charol.", ImageUrl = "3695.jpg", ImageUrl2 = "3695.jpg" },


        new() { Id = 32, Name = "Vomero 5 White & Metallic Silver", Brand = "Nike", Price = 159900, Description = "Diseño de estilo retro runner en tonos blanco y plateado metalizado con acentos en café.", ImageUrl = "579A.jpg", ImageUrl2 = "579A-alt.jpg" },
        new() { Id = 33, Name = "Invincible 3 Gore-Tex Turquoise", Brand = "Nike", Price = 159900, Description = "Modelo de alto rendimiento impermeable en tono turquesa con detalles en azul oscuro y verde neón.", ImageUrl = "845A.jpg", ImageUrl2 = "845A-alt.jpg" },
        new() { Id = 34, Name = "Air Max 97 Triple Black", Brand = "Nike", Price = 159900, Description = "Diseño icónico con líneas onduladas y cápsula de aire visible, completamente en color negro.", ImageUrl = "863.jpg", ImageUrl2 = "863-alt.jpg" },
        new() { Id = 35, Name = "LV Skate Sneaker White Monogram", Brand = "Louis Vuitton", Price = 159900, Description = "Zapatilla urbana de lujo en tono blanco con detalles acolchados y grabados del Monogram de la marca.", ImageUrl = "882.jpg", ImageUrl2 = "882-alt.jpg" },
        new() { Id = 36, Name = "530 White Silver & Navy", Brand = "New Balance", Price = 159900, Description = "Diseño clásico de running en malla blanca con superposiciones en plateado metalizado y detalles en azul marino.", ImageUrl = "893A.jpg", ImageUrl2 = "893A-alt.jpg" },
        new() { Id = 37, Name = "Pegasus EasyOn Black & White", Brand = "Nike", Price = 159900, Description = "Zapatilla de running deportiva en negro con swoosh lateral y suela gruesa en contraste blanco.", ImageUrl = "898A.jpg", ImageUrl2 = "898A-alt.jpg" },
        new() { Id = 38, Name = "Go Run Consistent Red & Black", Brand = "Skechers", Price = 159900, Description = "Diseño deportivo en rojo y negro con acentos amarillos y suela blanca ultraligera con perforaciones.", ImageUrl = "917M.jpg", ImageUrl2 = "917M-alt.jpg" },
        new() { Id = 39, Name = "Air Jordan 11 Retro Cherry", Brand = "Nike", Price = 159900, Description = "Silueta clásica con capellada en cuero blanco, detalles y suela en rojo vibrante.", ImageUrl = "4573.jpg", ImageUrl2 = "4573-alt.jpg" },
        new() { Id = 40, Name = "Air Jordan 11 Low Space Jam", Brand = "Nike", Price = 159900, Description = "Modelo de corte bajo en charol y malla totalmente negra con suela translúcida en tono azul.", ImageUrl = "4574.jpg", ImageUrl2 = "4574-alt.jpg" },
        new() { Id = 41, Name = "Air Jordan 3 Retro Olive Elephant", Brand = "Nike", Price = 159900, Description = "Diseño icónico en cuero verde oliva con el tradicional estampado de elefante y suela blanca con caucho café.", ImageUrl = "4575.jpg", ImageUrl2 = "4575-alt.jpg" },

        new() { Id = 42, Name = "Air Max Plus TN Black & Silver", Brand = "Nike", Price = 159900, Description = "Diseño degradado en tono negro y plateado con efectivas líneas protectoras y cápsulas de aire visibles.", ImageUrl = "94.jpg", ImageUrl2 = "94-alt.jpg" },
        new() { Id = 43, Name = "Air Max Plus TN White & Orange Accent", Brand = "Nike", Price = 159900, Description = "Zapatilla de tono blanco con base clara, acentos en naranja vibrante en el swoosh y la suela.", ImageUrl = "174.jpg", ImageUrl2 = "174-alt.jpg" },
        new() { Id = 44, Name = "Palermo White & Deep Green", Brand = "Puma", Price = 159900, Description = "Modelo clásico estilo terraza en cuero blanco con la icónica franja lateral en verde y suela de goma café.", ImageUrl = "643.jpg", ImageUrl2 = "643-alt.jpg" },
        new() { Id = 45, Name = "Air Max Plus Drift Light Green", Brand = "Nike", Price = 159900, Description = "Silueta moderna en verde mente con patrón texturizado y suela equipada con amortiguación de aire.", ImageUrl = "854.jpg", ImageUrl2 = "854-alt.jpg" },
        new() { Id = 46, Name = "Air Jordan 1 High Denim Light Blue", Brand = "Nike", Price = 159900, Description = "Diseño de caña alta confeccionado en mezcla de mezclilla azul claro con bordes desgastados y dijes metálicos dorados.", ImageUrl = "883.jpg", ImageUrl2 = "883-alt.jpg" },
        new() { Id = 47, Name = "Air Jordan 3 Retro Denim Obsidian", Brand = "Nike", Price = 159900, Description = "Zapatilla icónica confeccionada en textura de denim azul oscuro con el clásico grabado elephant print y acentos rojos.", ImageUrl = "887.jpg", ImageUrl2 = "887-alt.jpg" },
        new() { Id = 48, Name = "Air Jordan 4 Retro Craft Medium Olive & Biscuit", Brand = "Nike", Price = 159900, Description = "Edición especial en tonos blanco y crema con superposiciones de gamuza gris claro y acentos en café.", ImageUrl = "888.jpg", ImageUrl2 = "888-alt.jpg" },
        new() { Id = 49, Name = "Air Jordan 11 CMFT Low Black & Infrared", Brand = "Nike", Price = 159900, Description = "Diseño en cuero y charol negro con detalles interiores y suela exterior en rojo brillante.", ImageUrl = "889.jpg", ImageUrl2 = "889-alt.jpg" },
        new() { Id = 50, Name = "Air Jordan 4 Retro Frozen Moments", Brand = "Nike", Price = 159900, Description = "Elegante silueta en tonos gris neutro y crema con llamativos herrajes metálicos plateados.", ImageUrl = "891.jpg", ImageUrl2 = "891-alt.jpg" },
        new() { Id = 51, Name = "9060 Sea Salt & Mushroom", Brand = "New Balance", Price = 159900, Description = "Zapatilla de estilo futurista en tonos crema y beige con suela gruesa tridimensional.", ImageUrl = "4631.jpg", ImageUrl2 = "4631-alt.jpg" },

        new() { Id = 52, Name = "LV Trainer Sneaker Rhinestone Black", Brand = "Louis Vuitton", Price = 159900, Description = "Zapatilla de lujo en color negro completamente decorada con pedrería brillante y detalles de monograma.", ImageUrl = "001.jpg", ImageUrl2 = "001-alt.jpg" },
        new() { Id = 53, Name = "Hot Step 2 Drake Nocta White Metallic Silver", Brand = "Nike", Price = 159900, Description = "Diseño futurista e imponente en blanco puro con llamativos apliques cromados e imponentes líneas moldeadas.", ImageUrl = "002.jpg", ImageUrl2 = "002-alt.jpg" },
        new() { Id = 54, Name = "Duramo SL Black & White", Brand = "Adidas", Price = 159900, Description = "Modelo deportivo ligero en malla negra con las tres franjas icónicas y suela amortiguada en color blanco.", ImageUrl = "590M.jpg", ImageUrl2 = "590M-alt.jpg" },
        new() { Id = 55, Name = "Vomero 17 White & Infrared", Brand = "Nike", Price = 159900, Description = "Zapatilla de running de alto rendimiento en blanco con entresuela de doble densidad en naranja neón.", ImageUrl = "893M.jpg", ImageUrl2 = "893M-alt.jpg" },
        new() { Id = 56, Name = "Alphafly 3 Black & White", Brand = "Nike", Price = 159900, Description = "Calzado de competencia para atletismo en tejido transpirable negro con suela gruesa reactiva en blanco.", ImageUrl = "899M.jpg", ImageUrl2 = "899M-alt.jpg" },
        new() { Id = 57, Name = "Alphafly 3 White & Volt Yellow", Brand = "Nike", Price = 159900, Description = "Modelo running de alta velocidad en blanco con swoosh en negro y vibrantes acentos en amarillo neón.", ImageUrl = "905M.jpg", ImageUrl2 = "905M-alt.jpg" },
        new() { Id = 58, Name = "P-6000 Black & Metallic Silver", Brand = "Nike", Price = 159900, Description = "Estilo running de los años 2000 en combinación de malla gris y superposiciones estructuradas en negro y plateado.", ImageUrl = "910.jpg", ImageUrl2 = "910-alt.jpg" },
        new() { Id = 59, Name = "Air Force 1 Mid Black & Laser Blue", Brand = "Nike", Price = 159900, Description = "Silueta de corte medio en tono negro y gris oscuro con correa en el tobillo y detalles en azul cyan brillante.", ImageUrl = "4298.jpg", ImageUrl2 = "4298-alt.jpg" },
        new() { Id = 60, Name = "Air Jordan 1 Low Maroon & Pink", Brand = "Nike", Price = 159900, Description = "Diseño de corte bajo en elegante tono vino tinto con el característico swoosh en tono rosa neón.", ImageUrl = "4299.jpg", ImageUrl2 = "4299-alt.jpg" },
        new() { Id = 61, Name = "Air Jordan 3 Retro SE Denim Fire Red", Brand = "Nike", Price = 159900, Description = "Base de cuero blanco premium con detalles en mezclilla azul en el talón y puntera, complementado con acentos rojos.", ImageUrl = "4518.jpg", ImageUrl2 = "4518-alt.jpg" },

        new() { Id = 62, Name = "Air Jordan 1 High OG Phantom Gym Red", Brand = "Nike", Price = 159900, Description = "Cuero liso en tono gris claro con costuras contrastantes en rojo, cuello acolchado en color rojo y detalles clásicos de la línea Jordan.", ImageUrl = "4304.jpg", ImageUrl2 = "4304-alt.jpg" },
        new() { Id = 63, Name = "LV Trainer Sneaker Rhinestone Blue & Green", Brand = "Louis Vuitton", Price = 159900, Description = "Diseño de lujo cubierto en pedrería brillante azul marino y verde neón, con suela robusta y monograma de la marca.", ImageUrl = "4307.jpg", ImageUrl2 = "4307-alt.jpg" },
        new() { Id = 64, Name = "LV Trainer Sneaker Rhinestone Denim Blue", Brand = "Louis Vuitton", Price = 159900, Description = "Acabado exclusivo en tonos azul mezclilla y gris con incrustaciones de cristales deslumbrantes en todo el corte superior.", ImageUrl = "4308.jpg", ImageUrl2 = "4308-alt.jpg" },
        new() { Id = 65, Name = "Kyrie 7 Special FX / All-Star Red", Brand = "Nike", Price = 159900, Description = "Zapatilla de baloncesto con capellada textil de alto rendimiento en tonos rojos, detalles amarillos y suela multicolor en capas.", ImageUrl = "4481.jpg", ImageUrl2 = "4481-alt.jpg" },
        new() { Id = 66, Name = "Kyrie 7 Expressions Light Blue & Pink", Brand = "Nike", Price = 159900, Description = "Diseño dinámico en azul claro con superposiciones de colores pasteles, cordones en rosa suave y suela amortiguada en tono coral.", ImageUrl = "4482.jpg", ImageUrl2 = "4482-alt.jpg" },
        new() { Id = 67, Name = "Dunk Low Rose Whisper", Brand = "Nike", Price = 159900, Description = "Silueta clásica con base de cuero blanco y revestimientos en tono rosa suave ideal para un estilo urbano y sofisticado.", ImageUrl = "4569.jpg", ImageUrl2 = "4569-alt.jpg" },
        new() { Id = 68, Name = "Dunk Low Medium Olive", Brand = "Nike", Price = 159900, Description = "Estilo icónico de corte bajo en combinación bicolor con paneles en cuero blanco y revestimientos en verde oliva profundo.", ImageUrl = "4570.jpg", ImageUrl2 = "4570-alt.jpg" },
        new() { Id = 69, Name = "Dunk Low Pink Velvet Suede", Brand = "Nike", Price = 159900, Description = "Corte bajo de estilo retro confeccionado en gamuza rosa suave con base en cuero blanco y detalles de marca en los laterales.", ImageUrl = "4581.jpg", ImageUrl2 = "4581-alt.jpg" },
        new() { Id = 70, Name = "Dunk Low Tie-Dye Purple White", Brand = "Nike", Price = 159900, Description = "Diseño exclusivo con estampado desteñido en tonos azul y violeta pastel sobre base blanca con el swoosh en tono lila.", ImageUrl = "4629.jpg", ImageUrl2 = "4629-alt.jpg" },
        new() { Id = 71, Name = "Vomero 17 Dark Green Volt", Brand = "Nike", Price = 159900, Description = "Zapatilla de running en malla transpirable verde oscuro con un llamativo swoosh en amarillo volt y suela con tecnología ZoomX.", ImageUrl = "4636.jpg", ImageUrl2 = "4636-alt.jpg" },

        new() { Id = 72, Name = "Supernova Stride White Blue & Orange", Brand = "Adidas", Price = 159900, Description = "Modelo deportivo de running en color blanco con las tres franjas en azul marino, acentos en naranja y suela amortiguada Bounce.", ImageUrl = "297A.jpg", ImageUrl2 = "297A-alt.jpg" },
        new() { Id = 73, Name = "Supernova Rise 2 Triple Black", Brand = "Adidas", Price = 159900, Description = "Zapatilla de running completamente negra con franjas y detalles en blanco sobre entresuela con tecnología Dreamstrike+.", ImageUrl = "601A.jpg", ImageUrl2 = "601A-alt.jpg" },
        new() { Id = 74, Name = "Supernova Rise 2 Black White", Brand = "Adidas", Price = 159900, Description = "Diseño de alto rendimiento en malla negra con franjas laterales en blanco y suela gruesa amortiguada Dreamstrike+ en blanco contraste.", ImageUrl = "751A.jpg", ImageUrl2 = "751A-alt.jpg" },
        new() { Id = 75, Name = "Supernova Rise 2 Off White Orange & Teal", Brand = "Adidas", Price = 159900, Description = "Capellada ligera en blanco hueso con vibrantes franjas en naranja, cuello interior en verde azulado y suela reactiva Dreamstrike+.", ImageUrl = "899A.jpg", ImageUrl2 = "899A-alt.jpg" },
        new() { Id = 76, Name = "Supernova Rise 2 White Royal Blue", Brand = "Adidas", Price = 159900, Description = "Estilo running limpio y clásico en color blanco con acentos y las tres franjas icónicas en azul rey.", ImageUrl = "900A.jpg", ImageUrl2 = "900A-alt.jpg" },
        new() { Id = 77, Name = "Supernova Rise 2 White Sun Yellow", Brand = "Adidas", Price = 159900, Description = "Zapatilla deportiva en tono gris claro y blanco con franjas y degrada de suela en llamativo amarillo solar.", ImageUrl = "902A.jpg", ImageUrl2 = "902A-alt.jpg" },

        new() { Id = 78, Name = "LV Trainer Sneaker White & Black Accent", Brand = "Louis Vuitton", Price = 159900, Description = "Diseño de lujo en cuero premium blanco con detalles de marcos bordados y parches del logo LV en tono negro.", ImageUrl = "00001.jpg", ImageUrl2 = "00001-alt.jpg" },
        new() { Id = 79, Name = "Nike Sportswear Padded Slide Black", Brand = "Nike", Price = 159900, Description = "Chancla acolchada de estilo confort en color negro con ajuste por cordón elástico lateral y etiqueta Nike Sportswear.", ImageUrl = "01.jpg", ImageUrl2 = "01-alt.jpg" },
        new() { Id = 80, Name = "9060 Beige & Olive Green", Brand = "New Balance", Price = 159900, Description = "Silueta futurista en tonos beige, arena y verde oliva con paneles de gamuza y suela volumétrica tridimensional.", ImageUrl = "00002.jpg", ImageUrl2 = "00002-alt.jpg" },
        new() { Id = 81, Name = "Air Max Plus TN Black & Silver Swoosh", Brand = "Nike", Price = 159900, Description = "Zapatilla urbana totalmente negra con efectivas líneas onduladas de poliuretano, swoosh en contraste plateado y cápsulas de aire.", ImageUrl = "02H.jpg", ImageUrl2 = "02H-alt.jpg" },
        new() { Id = 82, Name = "Samba XLG White Black & Gum", Brand = "Adidas", Price = 159900, Description = "Versión moderna con suela de plataforma en goma caramelo, capellada de cuero blanco con puntera de gamuza gris y tres franjas negras.", ImageUrl = "00003.jpg", ImageUrl2 = "00003-alt.jpg" },
        new() { Id = 83, Name = "Dunk Low Supreme Off-White & Black", Brand = "Nike", Price = 159900, Description = "Edición especial estilo Supreme en cuero blanco hueso con bordes delineados, swoosh negro y minilogos en contraste.", ImageUrl = "00004.jpg", ImageUrl2 = "00004-alt.jpg" },
        new() { Id = 84, Name = "Air Force 1 Low Triple White Leather", Brand = "Nike", Price = 159900, Description = "Clásico atemporal completamente en cuero blanco impecable con chapa metálica AF1 en los cordones y suela gruesa en tono blanco.", ImageUrl = "005.jpg", ImageUrl2 = "005-alt.jpg" },
        new() { Id = 85, Name = "P-6000 Metallic Silver & Black", Brand = "Nike", Price = 159900, Description = "Estilo retro runner de los años 2000 en malla y revestimientos sintéticos en tono plateado metalizado con detalles negros.", ImageUrl = "00005.jpg", ImageUrl2 = "00005-alt.jpg" },
        new() { Id = 86, Name = "P-6000 Cream Beige & White", Brand = "Nike", Price = 159900, Description = "Diseño retro de running en malla transpirable y superposiciones en tonos crema y beige con swoosh contorneado en blanco.", ImageUrl = "006.jpg", ImageUrl2 = "006-alt.jpg" },
        new() { Id = 87, Name = "Free Metcon Purple & White", Brand = "Nike", Price = 159900, Description = "Zapatilla de entrenamiento y cross-training en tono violeta/morado con suela segmentada en blanco para máxima flexibilidad.", ImageUrl = "007.jpg", ImageUrl2 = "007-alt.jpg" },



        new() { Id = 88, Name = "Free Metcon Cream & Gold Accent", Brand = "Nike", Price = 159900, Description = "Zapatilla de entrenamiento en malla crema transpirable con detalles dorados en el swoosh y soporte talar robusto para estabilidad.", ImageUrl = "008.jpg", ImageUrl2 = "008-alt.jpg" },
        new() { Id = 89, Name = "Hyperboost White & Red", Brand = "Adidas", Price = 159900, Description = "Silueta deportiva vanguardista en capellada de malla roja con estructura blanca y suela amortiguada de gran volumen con detalles en rojo.", ImageUrl = "009.jpg", ImageUrl2 = "009-alt.jpg" },
        new() { Id = 90, Name = "Hyperboost White & Navy Blue", Brand = "Adidas", Price = 159900, Description = "Calzado deportivo moderno en tono azul marino profundo sobre estructura blanca fluida y mediasuela gruesa ultracómoda.", ImageUrl = "0010.jpg", ImageUrl2 = "0010-alt.jpg" },
        new() { Id = 91, Name = "LV Trainer Maxi Tweed Black & White", Brand = "Louis Vuitton", Price = 159900, Description = "Diseño de alta costura con textura de tweed deshilachado en blanco y negro, incrustaciones de pedrería y flor de monograma lateral.", ImageUrl = "0011.jpg", ImageUrl2 = "0011-alt.jpg" },
        new() { Id = 92, Name = "Terrex Soulstride White & Black", Brand = "Adidas", Price = 159900, Description = "Zapatilla de trail running en malla blanca reforzada con las tres rayas negras y suela de tracción Continental con acento rojo.", ImageUrl = "0012.jpg", ImageUrl2 = "0012-alt.jpg" },
        new() { Id = 93, Name = "Terrex Soulstride Gore-Tex Triple Black", Brand = "Adidas", Price = 159900, Description = "Zapatilla todoterreno impermeable con membrana Gore-Tex, capellada negra con tres franjas blancas y suela de agarre Continental.", ImageUrl = "0013.jpg", ImageUrl2 = "0013-alt.jpg" },
        new() { Id = 94, Name = "Air Force 1 Low Supreme x TNF Off-White", Brand = "Nike", Price = 159900, Description = "Edición colaborativa en cuero texturizado tono hueso, swoosh y parches grises con logotipos bordados de Supreme y The North Face.", ImageUrl = "163H.jpg", ImageUrl2 = "163H-alt.jpg" },
        new() { Id = 95, Name = "Hugo Boss Monogram Low-Top Black & Red", Brand = "Boss", Price = 159900, Description = "Sneaker casual de vestir en acabado charol y sintético grabado con monograma 'B' de la marca, detalles y ojales en rojo pasión.", ImageUrl = "179H.jpg", ImageUrl2 = "179H-alt.jpg" },
        new() { Id = 96, Name = "Air Force 1 Low 'Love for All' White", Brand = "Nike", Price = 159900, Description = "Calzado urbano en cuero granulado blanco con swoosh en relieve, grabado lateral de caligrafía y dubrae azul con la leyenda '333'.", ImageUrl = "221D.jpg", ImageUrl2 = "221D-alt.jpg" },
        new() { Id = 97, Name = "Air Force 1 Low Triple Black Matte", Brand = "Nike", Price = 159900, Description = "El clásico de la marca en acabado totalmente negro mate con entresuela de tono a juego y chapa metálica en los cordones.", ImageUrl = "222H.jpg", ImageUrl2 = "222H-alt.jpg" },




        new() { Id = 98, Name = "530 White Metallic Silver & Navy", Brand = "New Balance", Price = 159900, Description = "Zapatilla de estilo retro runner en malla transpirable blanca con superposiciones en plateado metalizado y detalles en azul marino.", ImageUrl = "487.jpg", ImageUrl2 = "487-alt.jpg" },
        new() { Id = 99, Name = "LV Trainer Monogram Black & White", Brand = "Louis Vuitton", Price = 159900, Description = "Diseño de lujo icónico en cuero blanco y negro con grabado del monograma LV, detalles distintivos de la marca y suela de goma bicolor.", ImageUrl = "487H.jpg", ImageUrl2 = "487H-alt.jpg" },
        new() { Id = 100, Name = "Mind Science Mule Slide White", Brand = "Nike", Price = 159900, Description = "Zueco deslizante futurista con diseño ergonómico de espuma blanca, perforaciones de ventilación y plantilla acolchada 'Mind Science'.", ImageUrl = "521H.jpg", ImageUrl2 = "521H-alt.jpg" },
        new() { Id = 101, Name = "Air Force 1 Low Snake Black", Brand = "Nike", Price = 159900, Description = "Edición especial con capellada en textura piel de serpiente totalmente negra, swoosh a juego y suela de goma clásica.", ImageUrl = "577H.jpg", ImageUrl2 = "577H-alt.jpg" },
        new() { Id = 102, Name = "P-6000 Light Bone & Gum", Brand = "Nike", Price = 159900, Description = "Silueta de running retro en tonos hueso y crema, con malla transpirable, swoosh delineado en blanco y suela exterior caramelo.", ImageUrl = "690D.jpg", ImageUrl2 = "690D-alt.jpg" },
        new() { Id = 103, Name = "Dunk Low Grey Suede & Black Swoosh", Brand = "Nike", Price = 159900, Description = "Diseño urbano en gamuza suave color gris claro con swoosh negro bordeteado y suela de goma a juego.", ImageUrl = "701H.jpg", ImageUrl2 = "701H-alt.jpg" },
        new() { Id = 104, Name = "Dunk Low Vintage Cream & Gold", Brand = "Nike", Price = 159900, Description = "Estilo clásico deslavado en tonos beige y crema con swoosh texturizado, minilogo bordado lateral y acabados de aspecto desgastado.", ImageUrl = "708H.jpg", ImageUrl2 = "708H-alt.jpg" },
        new() { Id = 105, Name = "Dunk Low SB Pure Platinum & White", Brand = "Nike", Price = 159900, Description = "Versión SB minimalista en capas de cuero blanco e inserciones en tono gris platino suave con suela de tracción duradera.", ImageUrl = "787D.jpg", ImageUrl2 = "787D-alt.jpg" },
        new() { Id = 106, Name = "Dunk Low University Blue & White", Brand = "Nike", Price = 159900, Description = "Diseño universitario en cuero blanco con superposiciones en azul claro, swoosh a juego y mini swoosh metálico lateral.", ImageUrl = "790D.jpg", ImageUrl2 = "790D-alt.jpg" },
        new() { Id = 107, Name = "Dunk Low Cacao Wow & White", Brand = "Nike", Price = 159900, Description = "Silueta clásica con contraste en paneles de cuero color café cacao y blanco, complementado con un mini swoosh dorado bordado.", ImageUrl = "791D.jpg", ImageUrl2 = "791D-alt.jpg" },


        new() { Id = 108, Name = "Dunk Low Medium Olive & White", Brand = "Nike", Price = 159900, Description = "Diseño clásico bocolor en capas de cuero blanco con superposiciones en verde oliva y suela de goma a juego.", ImageUrl = "792H.jpg", ImageUrl2 = "792H-alt.jpg" },
        new() { Id = 109, Name = "Cloudmonster Grey Blue", Brand = "On Running", Price = 159900, Description = "Zapatilla de alto rendimiento con amortiguación de gran volumen CloudTec, capellada de malla transpirable gris y detalles azules.", ImageUrl = "808H.jpg", ImageUrl2 = "808H-alt.jpg" },
        new() { Id = 110, Name = "9060 Rain Cloud Grey", Brand = "New Balance", Price = 159900, Description = "Silueta de estilo futurista con capellada en malla y gamuza tono gris claro, detalles reflectantes y suela abultada articulada.", ImageUrl = "826D.jpg", ImageUrl2 = "826D-alt.jpg" },
        new() { Id = 111, Name = "Dunk Low Supreme White Black", Brand = "Nike", Price = 159900, Description = "Colaboración urbana con cuerpo de cuero texturizado crema, swoosh negro en capas, detalles de minilogos bordados y etiqueta red Supreme.", ImageUrl = "832H.jpg", ImageUrl2 = "832H-alt.jpg" },
        new() { Id = 112, Name = "Dunk Low Platinum Pure Corduroy", Brand = "Nike", Price = 159900, Description = "Edición minimalista de tono hueso neutro con cordones de textura gruesa, swoosh en tono suave y detalles de mini swoosh bordado.", ImageUrl = "855H.jpg", ImageUrl2 = "855H-alt.jpg" },
        new() { Id = 113, Name = "Air Jordan 1 Retro High Union LA Storm Blue", Brand = "Jordan", Price = 159900, Description = "Silueta icónica de cuello alto estilo vintage en combinación de tonos azul, blanco y rojo, costuras expuestas y etiqueta Union LA.", ImageUrl = "866H.jpg", ImageUrl2 = "866H-alt.jpg" },
        new() { Id = 114, Name = "Air Force 1 Low Patent Grey & Black", Brand = "Nike", Price = 159900, Description = "Diseño exclusivo en charol brillante con bloque de color gris y negro, swoosh blanco de contraste y llavero decorativo.", ImageUrl = "896H.jpg", ImageUrl2 = "896H-alt.jpg" },
        new() { Id = 115, Name = "Air Force 1 Low Utility White & Black", Brand = "Nike", Price = 159900, Description = "Acabado en cuero grabado blanco con swoosh lateral impreso, etiqueta con texto informativo, mini swoosh frontal y tira en el talón.", ImageUrl = "897D.jpg", ImageUrl2 = "897D-alt.jpg" },
        new() { Id = 116, Name = "Dunk Low Cream Grey Leather", Brand = "Nike", Price = 159900, Description = "Estilo urbano en textura de cuero arrugado blanco hueso, swoosh gris claro y suela exterior de goma en tono coordinado.", ImageUrl = "898H.jpg", ImageUrl2 = "898H-alt.jpg" },
        new() { Id = 117, Name = "Air Max Plus Tuned 1 White Blue Teal", Brand = "Nike", Price = 159900, Description = "Diseño deportivo con estructura exterior translúcida sobre malla blanca, swoosh en tono turquesa y cápsulas de aire en azul brillante.", ImageUrl = "940H.jpg", ImageUrl2 = "940H-alt.jpg" },


        new() { Id = 118, Name = "9060 Magnet Black", Brand = "New Balance", Price = 159900, Description = "Diseño robusto en capas de gamuza y malla negra con acentos en gris oscuro, logo N lateral y suela escultórica abultada.", ImageUrl = "946D.jpg" },
        new() { Id = 119, Name = "9060 Beef and Broccoli Cream", Brand = "New Balance", Price = 159900, Description = "Estilo futurista retro en tonos crema y beige con detalles en café, verde oliva y suela amortiguada multicapa.", ImageUrl = "949D.jpg" },
        new() { Id = 120, Name = "Air Jordan 1 Low Travis Scott Labubu Purple", Brand = "Jordan", Price = 159900, Description = "Edición especial animada con swoosh invertido, base crema con superposiciones moradas y gráficos de Labubu bordados.", ImageUrl = "951D.jpg" },
        new() { Id = 121, Name = "Pegasus Trail 4 Sage Green", Brand = "Nike", Price = 159900, Description = "Zapatilla de trail running en malla verde menta con swoosh blanco de gran tamaño y suela de tracción para terrenos mixtos.", ImageUrl = "966D.jpg" },
        new() { Id = 122, Name = "530 White Burgundy", Brand = "New Balance", Price = 159900, Description = "Silueta retro de running en malla blanca respirable con superposiciones sintéticas en plata y burdeos sobre suela ABZORB.", ImageUrl = "968D.jpg" },
        new() { Id = 123, Name = "Bape Sta Low Grey Black Cloud", Brand = "Bape", Price = 159900, Description = "Diseño urbano con patrón grabado en textura gris, estrella Bape Sta en contraste negro y detalles de minilogo en el talón.", ImageUrl = "970D.jpg" },
        new() { Id = 124, Name = "Air Jordan 1 Mid Holographic Swoosh Ice Blue", Brand = "Jordan", Price = 159900, Description = "Corte medio en combinación de cuero blanco y azul celeste con swoosh iridiscente de efecto holográfico y suela translúcida.", ImageUrl = "1002D.jpg" },
        new() { Id = 125, Name = "530 Triple White", Brand = "New Balance", Price = 159900, Description = "Estilo clásico deportivo en tono monocromático blanco y hueso, capellada de malla transpirable y amortiguación ABZORB.", ImageUrl = "1014D.jpg" },
        new() { Id = 126, Name = "Dunk Low Bordeaux", Brand = "Nike", Price = 159900, Description = "Diseño icónico bicolor con base de cuero blanco, superposiciones en tono vinotinto profundo y suela de goma a juego.", ImageUrl = "1022H.jpg" },
        new() { Id = 127, Name = "Air Force 1 Low Patent Red Orange", Brand = "Nike", Price = 159900, Description = "Edición llamativa en charol brillante de color rojo vino con swoosh y cordones en tono naranja vibrante.", ImageUrl = "1027D.jpg" },



        new() { Id = 128, Name = "Air Force 1 Low Travis Scott x The North Face Brown", Brand = "Nike", Price = 159900, Description = "Colaboración urbana en tonos marrón y crema, swoosh con relieve de líneas, etiquetas con logo de The North Face y llavero decorativo.", ImageUrl = "1028H.jpg" },
        new() { Id = 129, Name = "Dunk Low CDG x The North Face Light Grey Blue", Brand = "Nike", Price = 159900, Description = "Diseño en gamuza gris claro con swoosh estampado de microtextos CDG en azul, logo de The North Face bordado y llavero especial.", ImageUrl = "1043H.jpg" },
        new() { Id = 130, Name = "Air Max 90 Essential Black White Gum", Brand = "Nike", Price = 159900, Description = "Silueta clásica de running en malla y capas sintéticas completamente negras, swoosh blanco de contraste y suela de goma gum.", ImageUrl = "1052H.jpg" },
        new() { Id = 131, Name = "Air Max Plus Tuned 1 Tie-Dye Teal White", Brand = "Nike", Price = 159900, Description = "Capellada de malla con estampado estilo tie-dye en tonos azul turquesa y blanco, jaula exterior de TPU translúcida y suela Air.", ImageUrl = "BB17.jpg" },
        new() { Id = 132, Name = "Shox R4 Metallic Silver Black Blue", Brand = "Nike", Price = 159900, Description = "Estilo futurista retro en combinación plateada y negra con swoosh bordado y columnas de amortiguación Shox en azul brillante.", ImageUrl = "BB156.jpg" },
        new() { Id = 133, Name = "Terrex Soulstride Rain.Rdy Black Olive", Brand = "Adidas", Price = 159900, Description = "Calzado técnico de trail con membrana Gore-Tex, capellada en tonos negro, verde oliva y gris, mediasuela Dreamstrike y suela Continental.", ImageUrl = "FFF376.jpg" },
        new() { Id = 134, Name = "Terrex Soulstride Rain.Rdy Cream Orange", Brand = "Adidas", Price = 159900, Description = "Diseño outdoor en malla resistente beige y crema con detalles en naranja vibrante, protección Gore-Tex y suela Continental de alta tracción.", ImageUrl = "FFF377.jpg" },
        new() { Id = 135, Name = "Supernova Solution Black White Red", Brand = "Adidas", Price = 159900, Description = "Zapatilla de running de alto rendimiento en malla transpirable negra con tres franjas blancas gruesas, tecnología Dreamstrike Glow y detalles rojos.", ImageUrl = "FFF382.jpg" },
        new() { Id = 136, Name = "Supernova Solution Light Grey Bronze", Brand = "Adidas", Price = 159900, Description = "Silueta deportiva en tono gris claro neutro con acentos en bronce metálico, tres franjas blancas y suela de amortiguación Dreamstrike Glow.", ImageUrl = "FFF383.jpg" },
        new() { Id = 137, Name = "9060 Triple Black", Brand = "New Balance", Price = 159900, Description = "Edición monocromática totalmente negra en capas de gamuza y malla transpirable, con distintiva suela gruesa y esculpida.", ImageUrl = "FFF386.jpg" },

        new() { Id = 138, Name = "9060 Rain Cloud Grey", Brand = "New Balance", Price = 159900, Description = "Silueta futurista en tonos gris claro y plateado con capas de gamuza, logo N bordado en azul claro y suela escultórica amortiguada.", ImageUrl = "FFF387.jpg" },
        new() { Id = 139, Name = "9060 Cream Wine Green", Brand = "New Balance", Price = 159900, Description = "Diseño retro-futurista con base de malla crema, superposiciones en rosa pálido, detalles en vino tinto y verde oscuro en la mediasuela.", ImageUrl = "FFF388.jpg" },
        new() { Id = 140, Name = "9060 Grey Navy", Brand = "New Balance", Price = 159900, Description = "Estilo en capas con tonos gris y crema, detalles de contraste en azul marino en el logo N y panel superior, sobre suela prominente ABZORB.", ImageUrl = "FFF389.jpg" },
        new() { Id = 141, Name = "Air Jordan 5 Retro UNC University Blue", Brand = "Jordan", Price = 159900, Description = "Corte alto en gamuza azul universitario con lengüeta reflectante gris, detalles de dientes de tiburón blancos en la suela negra y parche posterior.", ImageUrl = "FFF391.jpg" },
        new() { Id = 142, Name = "Air Max Plus Drift Triple Black", Brand = "Nike", Price = 159900, Description = "Diseño agresivo y moderno en color negro mate con estructura de goma moldeada sobre la capellada y cápsulas de aire visibles.", ImageUrl = "FFF398.jpg" },
        new() { Id = 143, Name = "Essential Signature White Black", Brand = "Tommy Hilfiger", Price = 159900, Description = "Tenis de estilo casual en cuero sintético blanco con la firma Tommy Hilfiger en el lateral, detalle de bandera en la lengüeta y talón negro.", ImageUrl = "FFF399.jpg" },
        new() { Id = 144, Name = "LV Trainer Denim Blue White", Brand = "Louis Vuitton", Price = 159900, Description = "Silueta de lujo urbana en cuero blanco combinado con paneles de lona con patrón Monogram en denim azul y suela de goma a juego.", ImageUrl = "FFF401.jpg" },
        new() { Id = 145, Name = "Dunk Low Disrupt 2 Pale Ivory Coral", Brand = "Nike", Price = 159900, Description = "Diseño deconstruido en tono crema claro con bordados de swoosh en coral y verde menta, ojales asimétricos y suela moteada sostenible.", ImageUrl = "FFF402.jpg" },
        new() { Id = 146, Name = "NOCTA x Hot Step 2 Black Gold", Brand = "Nike", Price = 159900, Description = "Colaboración con Drake en capellada de líneas fluidas color negro con acabados metálicos en dorado brillante en los laterales y talón.", ImageUrl = "FFF404.jpg" },
        new() { Id = 147, Name = "Dunk Low Cacao Wow", Brand = "Nike", Price = 159900, Description = "Diseño clásico bicolor con base de cuero blanco hueso, superposiciones en tono marrón café y suela exterior a juego.", ImageUrl = "GGG11.jpg" },




        new() { Id = 148, Name = "Air Jordan 1 Low Shadow Red", Brand = "Jordan", Price = 159900, Description = "Silueta baja con base de cuero gris y negro, Swoosh en rojo intenso y suela de goma roja a juego.", ImageUrl = "GGG13.jpg" },
        new() { Id = 149, Name = "Air Jordan 1 Low Midnight Navy Grey", Brand = "Jordan", Price = 159900, Description = "Diseño de corte bajo en base blanca con superposiciones azul marino, Swoosh gris y suela a juego.", ImageUrl = "GGG20.jpg" },
        new() { Id = 150, Name = "Air Jordan 1 High Denim Washed", Brand = "Jordan", Price = 159900, Description = "Corte alto con paneles de textil estilo mezclilla desgastada azul, base blanca de cuero y Swoosh gris.", ImageUrl = "GGG24.jpg" },
        new() { Id = 151, Name = "Air Jordan 1 Mid Royal Blue Black", Brand = "Jordan", Price = 159900, Description = "Silueta de corte medio en combinación clásica de cuero azul real y negro con suela de tracción azul.", ImageUrl = "GGG25.jpg" },
        new() { Id = 152, Name = "Air Jordan 1 Mid Shadow Toe", Brand = "Jordan", Price = 159900, Description = "Corte medio con bloques de color en gris claro y negro, Swoosh lateral a juego y detalles en rojo en el logo.", ImageUrl = "GGG27.jpg" },
        new() { Id = 153, Name = "Air Jordan 1 Mid Shadow Red Inner", Brand = "Jordan", Price = 159900, Description = "Diseño en paneles de cuero gris y negro con Swoosh en gris y forro interno acolchado en color rojo vibrante.", ImageUrl = "GGG30.jpg" },
        new() { Id = 154, Name = "Air Jordan 1 High Bordeaux White", Brand = "Jordan", Price = 159900, Description = "Silueta alta clásica en cuero blanco brillante con superposiciones en tono vino borgoña y Swoosh a juego.", ImageUrl = "GGG31.jpg" },
        new() { Id = 155, Name = "Air Jordan 1 Mid Reverse Bred", Brand = "Jordan", Price = 159900, Description = "Diseño de corte medio en icónico cuero rojo y negro con Swoosh rojo destacado y suela de goma a juego.", ImageUrl = "GGG37.jpg" },
        new() { Id = 156, Name = "Air Jordan 1 Mid Obsidian White", Brand = "Jordan", Price = 159900, Description = "Estilo clásico de corte medio con capellada en cuero blanco y superposiciones en azul marino obsidian.", ImageUrl = "GGG39.jpg" },
        new() { Id = 157, Name = "Air Force 1 Low Patent Black Grey", Brand = "Nike", Price = 159900, Description = "Corte bajo en charol negro brillante con paneles grises, Swoosh blanco y suela traslúcida azulada.", ImageUrl = "GGG57.jpg" },

        new() { Id = 158, Name = "Samba OG White Light Blue", Brand = "Adidas", Price = 159900, Description = "Silueta clásica con capellada de cuero blanco, punta de gamuza gris, tres rayas y talón en azul celeste sobre suela de goma caramelo.", ImageUrl = "GGG60.jpg" },
        new() { Id = 159, Name = "Air Jordan 1 Low Coconut Milk Midnight Navy", Brand = "Jordan", Price = 159900, Description = "Corte bajo elegante con base blanca, superposiciones en tono crema coconut milk, Swoosh azul marino y suela exterior de goma caramelo.", ImageUrl = "GGG188.jpg" }





    ];

    public static List<Product> GetAll() => Products;

    public static Product? GetById(int id) => Products.FirstOrDefault(p => p.Id == id);
}
