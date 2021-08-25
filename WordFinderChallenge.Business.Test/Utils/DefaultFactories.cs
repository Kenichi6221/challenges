using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinderChallenge.Business.Test.Utils
{
    public class DefaultFactories
    {
        public Cell BuildCell(int currentRow = 5, int currentColumn = 5, int maxRow = 5, int maxColumn = 5)
        {
            return new Cell(currentRow, currentColumn, maxRow, maxColumn);
        }

        public IEnumerable<string> GetWordStreamWithDuplicates()
        {
            IEnumerable<string> wordStream = new List<string>{
               "can","chill","cold","door","love","wind","dear","more","would","chill","dummy","successful"
            };
            return wordStream;
        }

        public IEnumerable<string> GetWordStream()
        {
            IEnumerable<string> wordStream = new List<string>{
               "can","chill","cold","door","love","wind","dear","more","would","dummy","successful"
            };
            return wordStream;
        }

        public IEnumerable<string> GetWordStreamLongWord()
        {
            IEnumerable<string> wordStream = new List<string>{
               "veryloooongWooord"
            };
            return wordStream;
        }

        public IEnumerable<string> GetMatrix5x5()
        {
            IEnumerable<string> matrix = new List<string>{
                "abcdc","fgwio","chill","pqnsd","uvdxy"
            };
            return matrix;
        }

        public IEnumerable<string> GetMatrix14x14()
        {   
            IEnumerable<string> matrix = new List<string>{
                "wouldnkpsdzmem",
                "hsrjwindsjcwom",
                "ledooroljkpdkr",
                "tayjxgfdtixpeq",
                "ycvbkrchillxud",
                "knnqmvcdlxnppr",
                "pcqdlkmbucoldt",
                "ayelpfezbqdoor",
                "ycchilldearljy",
                "safjngxzywkibq",
                "canhhykcloveon",
                "sopqmorehstrht",
                "fdnrmcoldziwgt",
                "lxgiitocgmhuqf"
            };
            return matrix;
        }

        public IEnumerable<string> GetMatrix64x64()
        {
            IEnumerable<string> matrix = new List<string>{
                "ipaapqwwgcrzcqhdtefaxruzpblauxxzxskmjxutdzhisyndxkywawcozaigygtp",
                "itwimhectvfzzcytftmzypyveoyvoyffblnqboyandqqvzmiiehvloveqxyejczy",
                "dyuhudmyttyczkoprelrbbivwexkzxcdzgkbtjlzxstwkvcrcssolliedkxuwfkq",
                "jobzdnjfpypzwpxthqrrczvmfmxabbnglefvszsqgepbsdlutexlzlnwmfxgbqzk",
                "bhxyakrcdnntawykuvanmzornvffrngfqsvagsuaiiljqsfugmqwcgcoghofohlo",
                "zbuvacxbueprkfjyxubcevmrvknziwdtljrlsxtvumustvzbvgmrleypmhwymzit",
                "pldbfxszvxpsnkerftusjrpjlgpfhuoncnsnmdstcbcubdwhhvjwzlvwuvmqgynb",
                "bxzncjnieeosplhikbscdvyuwgzvquglggcvpbfnqpzudwvbdhivhufyonamyyfy",
                "ojnicewxzurkgymnhyntbcdpxplwrefydfxsndsqfpyqoqjoqproeqhgdzodeyee",
                "kpozhqsipdeakuxublpddfhunlbyltswigslctldupuhjsefnoknglxvvoioqslj",
                "incxkpbpsbckrpiturwcsyujtnihkunvexlufmmycyqtoqazakafztdczuksqhiv",
                "jnpmcwwodummyrizuphskyqzfvvqfjuefjcziyzaqoahclsihcakwntdxemrmplt",
                "wjvdnsuccessfulorkksijozdbkdoordzgovowomkqgpfvrwsxliyrdbpeqgjhqh",
                "lkcjbodmfjzqgalbnbxwvbeeykdkaskkquliaajiinjdlwomuusoqqyxvltcsmul",
                "ljjsejzntapjyagqofrlhxyxjmqvjeuhpzbbnnspovxvofvuzuayobxkqibvhgez",
                "loebjedtyxqccfixdpipucqmtcwhreifsgdearqeycanreyijonaozlbgxoovalj",
                "hqslqxawsgvpbyegemaziuxkpjxvakcbacnhztnhsmwnacinynaamxvfxnfaokcw",
                "mkuxtqepdcdascmoreccrjcupvjacmeyfawohdhbsglfkzzcmfpkepmulxqyncrc",
                "ryioedsondzzugogiafavklqtbghfynjbhvhedzbxdoorvgtmlajndpjxwzzrola",
                "oehrwsuccessfulboctrzmnmfobsyfsdyfljqpuexozcnzxdgzeajvwpnbtiapxl",
                "ywqrbbvcwfeaptumpliisdskxwindsjiayuldhmktkvnwkjolobpyphnezlbipxj",
                "zjdnfqbcaasrwyelujtkoslesodvbquqijbraniwyckwgzbhqfhvrcjbmshdlojh",
                "cywwbvvqffivebsfmacqowzgfqtogfmuqjygdzppakvkqdkmmjecafjmyuozuqzz",
                "hclqgcwtkmmbedvlvewqstjeycyzormnmhywprsgavcxeioshptqnxadzmbjkmbs",
                "iahwesnodbvadzoyfhnnegomqgefremrnfaijwvofgjbvsvupfumahngmucorkhc",
                "ldlpmblrenadhuycrihzgatohnljoimcxfjmpzgfstqirfeahoobelghmgqxnpwj",
                "lmmqhztqpchtqyumrtxyfmkdqnybwpcipdjwzikwubgzbgzwhgswgajbyiudwzrq",
                "uqqsmltusuapdbfnvmzpkzytvsvetzodqjkzaupgqsmxjxjabaauibmlexawkule",
                "jvvwjuhhdcybjysjmqardokcflgyepmlysstumbqbhucjsfrvnvkzxfbvjuckali",
                "mgmbknnusklsvurqmpzqcixvsreyzhmapevbhkrxellgprapguhbzymmfewtqyym",
                "jvgnovmuplvzvfgsmhdkcjdnniyegsjmjeakvzjqxmzghgcplraeceyaxjpeoaxw",
                "kwcoqpvofvtebfrcaaojsajabeofueqbhvflmoejfkzkugbtyghyosouoxvniylj",
                "vwxmvabgzpcyhbydbioojyyohgvwsbcllrqbvjpyggsnereqqprsgdjivqmpojvf",
                "vxrbpqnyebatgpfupezfqxuyfhsovnlzqrdzmyoqasgfdtdfdndugnurchgzuqdq",
                "kzkoaqitrxqnirefveposkdwouldkaabwrhkcyhiahenplhcvqghewalwillrsti",
                "sbysmzadmejmdobwczdsyqmwbgvqapkfwwteggqdjdwukfiaalnzkgsniklbdmbp",
                "zjvbassdyxueacfeyxebwtygvbizdiifdcrghpiorvwqmcimydhjaoyekdbowaol",
                "xuwcnchduhhhstckkugaxigfucpujmujnygdfafmmmzrgohwhtofsodlrccpapwv",
                "qitzhhkkrauswlsqspbthiydupegwqvcaybbmmxlomezazbpxsithagwvfntrawz",
                "xkoiqsqxxrbwbppqzvaapvclwjgtouvgxdnyulzegymyumsttbltjnvvpqjckkjr",
                "ujaazuerkwpbeqjowbihhhednmtkewrykbaxhievdpgpxvzrfxiqpnsuccessful",
                "fcfnxvqmuembiccnobimpcwuvrjttvgscbcksdathqcftduvmsalhqwuwgzmwroa",
                "zqxhspdybzzkucsqcztmnynmtohhtuykcpvxytxquytnoinyfkwaeipflixvaxaw",
                "dwipccuoyxrmehzttqlowqufrrpphglgstfetjpgwzgzxqlsalxcvkmwqggzjhth",
                "ujtygyxcyuthdekzgpaiaqrslrdwqibzdlepvobtsqmfidtotydorvttqmifeshd",
                "ihxgayqsjgpirmchmdebutjwhtqdsngyejvhctzmfqwlsqfavzidyzpwygapgggg",
                "glgfhvtcuagcjwdlwwgymiwgvfyhraelhjtukicarwiofqcofcgmbdrmvnnufgbd",
                "dmvzocmxduejzftngzgzjazbbqnlrvonjxijurniceaepkgtxgkzbqdgtzqwglqd",
                "jmawenmufwjcqypqmofaaszpcntcvkostchznzgmfvbueybemwrxgmjtguifktrg",
                "thguukqstlbmehgwbzbfbricjgmeaxbnggndmigqzsiortmmhrnskcyfhhuyeniv",
                "mvjfrkhvwloapbqqafrlazvaodqynbirdddzuyyozbtohargrjkdigiuludzzsyd",
                "nutgrpritwqsrzxgbdpvdujvdmwlneqdowkhmjfyqaxbyqehvijcfbvxkbdjavbv",
                "tvbismwczczbwyegskxuqutvcktgommvrggzsvsbcgnxmhacwbdwcjfywiabuodf",
                "emkogfcdapwzpdzprkirfulubpwenxaecdxnjrsxlscgfkwnjiprbigfepnkflyt",
                "nuivwecaatykacqvaoadjnrndcggleiomeramqqcyytbnyoycgsybhccpcppkhaf",
                "waafqdzeybppigmvsxdsilbufmuyazsfvclugsoyrgxrcjvoyypmjlbvgftscyxy",
                "mukmwikkxpnflznzjpkosgkrmtcdfgmdfzdytyzhodvjatrracmtqburvpwvklvm",
                "dzhzpgumeueifypegxdqjiaijqzqskexfyjermlvvbsnhummyvqjyyviulagwwex",
                "plspgwgeidompwouldznfwxfevxrxxcnshfrkvemncvhsehldlufsseccusmcyrd",
                "ozlfggeglivmvpiutzkfenpyaqsqpotdctpmsqpzwnddkvuubaauqhcwlabxeskp",
                "pqamgsfkszdnruqidovbefmwfyixczivnizplwnzcldcqoltbmjuygkjimjgxuim",
                "gaqkbjhhihfnsbkwymohnaaobljhzndhddloctrahiuyqcmjwjfzvrkyujnppixj",
                "kcxrnwotyctrdxaclkkfnbepltcnrcvfgaptunpwjlhrzxuyxwntvtqjgwsxcwwl",
                "coldnryveecoyfpqwoeszvcdyqpxgcdfmnyvytamtfrgsrjdvdcpgdeqzriczutm"
            };
            return matrix;
        }
    }
}
