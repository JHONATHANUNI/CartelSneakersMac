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
        new() { Id = 77, Name = "Supernova Rise 2 White Sun Yellow", Brand = "Adidas", Price = 159900, Description = "Zapatilla deportiva en tono gris claro y blanco con franjas y degrada de suela en llamativo amarillo solar.", ImageUrl = "902A.jpg", ImageUrl2 = "902A-alt.jpg" }

    ];

    public static List<Product> GetAll() => Products;

    public static Product? GetById(int id) => Products.FirstOrDefault(p => p.Id == id);
}
