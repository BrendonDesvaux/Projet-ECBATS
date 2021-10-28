using Microsoft.EntityFrameworkCore.Migrations;

namespace ECBATS_Test.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    CryptoName = table.Column<string>(type: "TEXT", nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<string>(type: "TEXT", nullable: true),
                    Percent24h = table.Column<string>(type: "TEXT", nullable: true),
                    Percent7j = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "bitcoin", "btc", "https://assets.coingecko.com/coins/images/1/large/bitcoin.png?1547033579", "1.8497533421051617", "-8.957777811272306}", "51735", "Bitcoin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "ethereum-classic", "etc", "https://assets.coingecko.com/coins/images/453/large/ethereum-classic-logo.png?1547034169", "9.16786432015224", "-5.702466566712895}", "45.24", "Ethereum Classic" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "filecoin", "fil", "https://assets.coingecko.com/coins/images/12817/large/filecoin.png?1602753933", "3.240084789473717", "-11.705658546982608}", "50.85", "Filecoin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "ftx-token", "ftt", "https://assets.coingecko.com/coins/images/9026/large/F.png?1609051564", "0.40116109766854163", "-2.7175857999012405}", "51.33", "FTX Token" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "internet-computer", "icp", "https://assets.coingecko.com/coins/images/14495/large/Internet_Computer_logo.png?1620703073", "2.1033087855925103", "-6.5283283603311375}", "37.73", "Internet Computer" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "dai", "dai", "https://assets.coingecko.com/coins/images/9956/large/dai-multi-collateral-mcd.png?1574218774", "1.3555061498349052", "1.3638020203438417}", "0.869889", "Dai" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "axie-infinity", "axs", "https://assets.coingecko.com/coins/images/13029/large/axie_infinity_logo.png?1604471082", "2.908265828635455", "-0.07879243109175665}", "109.73", "Axie Infinity" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "stellar", "xlm", "https://assets.coingecko.com/coins/images/100/large/Stellar_symbol_black_RGB.png?1552356157", "1.363655034017778", "-11.427766585980013}", "0.29794", "Stellar" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "fantom", "ftm", "https://assets.coingecko.com/coins/images/4001/large/Fantom.png?1558015016", "18.490172556076615", "37.06610147126002}", "2.87", "Fantom" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "vechain", "vet", "https://assets.coingecko.com/coins/images/1167/large/VeChain-Logo-768x725.png?1547035194", "2.7465292623639415", "7.887083119238239}", "0.113541", "VeChain" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "bitcoin-cash", "bch", "https://assets.coingecko.com/coins/images/780/large/bitcoin-cash-circle.png?1594689492", "2.7052530776369026", "-10.304833881545099}", "495.44", "Bitcoin Cash" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "cosmos", "atom", "https://assets.coingecko.com/coins/images/1481/large/cosmos_hub.png?1555657960", "6.273840920065187", "11.828937606861507}", "34.51", "Cosmos" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "algorand", "algo", "https://assets.coingecko.com/coins/images/4380/large/download.png?1547039725", "1.3565172999200086", "2.8018955753672925}", "1.58", "Algorand" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "matic-network", "matic", "https://assets.coingecko.com/coins/images/4713/large/matic-token-icon.png?1624446912", "11.632257002880527", "25.43765069567633}", "1.65", "Polygon" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "litecoin", "ltc", "https://assets.coingecko.com/coins/images/2/large/litecoin.png?1547033580", "3.332938290329611", "-9.582569379058747}", "161.09", "Litecoin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "tron", "trx", "https://assets.coingecko.com/coins/images/1094/large/tron-logo.png?1547035066", "4.179606334000939", "-7.5415074078892586}", "0.082178", "TRON" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "uniswap", "uni", "https://assets.coingecko.com/coins/images/12504/large/uniswap-uni.png?1600306604", "1.7915549365985142", "-7.326609603364504}", "21.52", "Uniswap" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "wrapped-bitcoin", "wbtc", "https://assets.coingecko.com/coins/images/7598/large/wrapped_bitcoin_wbtc.png?1548822744", "1.7255970100118498", "-9.050120225947248}", "51655", "Wrapped Bitcoin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "avalanche-2", "AVAX", "https://assets.coingecko.com/coins/images/12559/large/coin-round-red.png?1604021818", "1.7025520997930632", "7.189509942003525}", "54.99", "Avalanche" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "chainlink", "link", "https://assets.coingecko.com/coins/images/877/large/chainlink-new-logo.png?1547034700", "1.9612954105958467", "11.361027676265433}", "26.3", "Chainlink" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "terra-luna", "luna", "https://assets.coingecko.com/coins/images/8284/large/luna1557227471663.png?1567147072", "3.771259028386963", "-2.713271174138225}", "35.72", "Terra" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "usd-coin", "usdc", "https://assets.coingecko.com/coins/images/6319/large/USD_Coin_icon.png?1547042389", "0.8879354456476051", "0.913571815745507}", "0.868303", "USD Coin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "shiba-inu", "shib", "https://assets.coingecko.com/coins/images/11939/large/shiba.png?1622619446", "35.03007087755212", "144.26406943036312}", "6.128e-05", "Shiba Inu" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "dogecoin", "doge", "https://assets.coingecko.com/coins/images/5/large/dogecoin.png?1547792256", "34.31770172740452", "22.861671158261306}", "0.268272", "Dogecoin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "polkadot", "dot", "https://assets.coingecko.com/coins/images/12171/large/aJGBjJFU_400x400.jpg?1597804776", "2.4200732739282964", "-4.216442590082043}", "36.61", "Polkadot" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "ripple", "xrp", "https://assets.coingecko.com/coins/images/44/large/xrp-symbol-white-128.png?1605778731", "4.928361648518545", "-6.33583603300895}", "0.918881", "XRP" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "solana", "sol", "https://assets.coingecko.com/coins/images/4128/large/Solana.jpg?1635329178", "2.7943167656470966", "11.504988307870914}", "167.98", "Solana" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "cardano", "ada", "https://assets.coingecko.com/coins/images/975/large/cardano.png?1547034860", "2.504403196375786", "-8.3315486642433}", "1.73", "Cardano" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "tether", "usdt", "https://assets.coingecko.com/coins/images/325/large/Tether-logo.png?1598003707", "1.6249345119997385", "1.4230339557818743}", "0.870067", "Tether" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "binancecoin", "bnb", "https://assets.coingecko.com/coins/images/825/large/binance-coin-logo.png?1547034615", "5.264158433080324", "-5.025007946833159}", "409.93", "Binance Coin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "ethereum", "eth", "https://assets.coingecko.com/coins/images/279/large/ethereum.png?1595348880", "1.9497397418281153", "-1.0337495464881228}", "3540.51", "Ethereum" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "binance-usd", "busd", "https://assets.coingecko.com/coins/images/9576/large/BUSD.png?1568947766", "1.4282146480147409", "1.210537286073843}", "0.871305", "Binance USD" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Image", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { "compound-ether", "ceth", "https://assets.coingecko.com/coins/images/10643/large/ceth2.JPG?1581389598", "1.4769305783640105", "-1.2679907705517892}", "70.82", "cETH" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
