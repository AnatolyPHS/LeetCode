using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start()
    {
        Debug.Log(MinWindow("obzcopzocynyrsgsarijyxnkpnukkrvzuwdjldxndmnvevpgmxrmvfwkutwekrffnloyqnntbdohyfqndhzyoykiripdzwiojyoznbtogjyfpouuxvumtewmmnqnkadvzrvouqfbbdiqremqzgevkbhyoznacqwbhtrcjwfkzpdstpjswnpiqxjhywjanhdwavajrhwtwzlrqwmombxcaijzevbtcfsdcuovckoalcseaesmhrrizcjgxkbartdtotpsefsrjmvksqyahpijsrppdqpvmuocofuunonybjivbjviyftsyiicbzxnwnrmvlgkzticetyfcvqcbjvbufdxgcmesdqnowzpshuwcseenwjqhgsdlxatamysrohfnixfprdsljyyfhrnnjsagtuihuczilgvtfcjwgdhpbixlzmakebszxbhrdibpoxiwztshwczamwnninzmqrmpsviydkptjzpktksrortapgpxwojofxeasoyvyprjoguhqobehugwdvtzlenrcttuitsiijswpogicjolfxhiscjggzzissfcnxnvgftxvbfzkukqrtalvktdjsodmtgzqtuyaqvvrbuexgwqzwduixzrpnvegddyyywaquxjxrnuzlmyipuqotkghfkpknqinoidifnfyczzonxydtqroazxhjnrxfbmtlqcsfhshjrxwqvblovaouxwempdrrplefnxmwrwfjtebrfnfanvvmtbzjesctdgbsfnpxlwihalyiafincfcwgdfkvhebphtxukwgjgplrntsuchyjjuqozakiglangxkttsczhnswjksnuqwflmumpexxrznzwxurrysaokwxxqkrggytvsgkyfjrewrcvntomnoazmzycjrjrqemimyhriyxgrzcfuqtjhvjtuhwfzhwpljzajitrhryaqchnuawbxhxrpvyqcvhpggrpplhychyulijhkglinibedauhvdydkqszdbzfkzbvhldstocgydnbfjkcnkfxcyyfbzmmyojgzmasccaahpdnzproaxnexnkamwmkmwslksfpwirexxtymkmojztgmfhydvlqtddewjvsrmyqjrpycbmndhupmdqqabiuelacuvxnhxgtpvrtwfgzpcrbhhtikbcqpctlxszgpfbgcsbaaiapmtsucocmpecgixshrrnhyrpalralbccnxvjzjllarqhznzghswqsnfuyywmzbopyjyauknxddgdthlabjqtwxpxwljvoxkpjjpfvccyikbbrpdsyvlxscuoofkecwtnfkvcnzbxkeabtdusyhrqklhaqreupakxkfzxgawqfwsaboszvlshwzhosojjotgyagygguzntrouhiweuomqptfjjqsxlbylhwtpssdlltgubczxslqjgxuqnmpynnlwjgmebrpokxjnbiltvbebyytnnjlcwyzignmhedwqbfdepqakrelrdfesqrumptwwgifmmbepiktxavhuavlfaqxqhreznbvvlakzeoomykkzftthoemqwliednfsqcnbexbimrvkdhllcesrlhhjsspvfupxwdybablotibypmjutclgjurbmhztboqatrdwsomnxnmocvixxvfiqwmednahdqhxjkvcyhpxxdmzzuyyqdjibvmfkmonfxmohhshpkhmntnoplphqyprveyfsmsxjfosmicdsjrieeytpnbhlsziwxnpmgoxneqbnufhfwrjbqcsdfarybzwaplmxckkgclvwqdbpumsmqkswmjwnkuqbicykoisqwoootrdpdvcuiuswfqmrkctsgrevcxnyncmivsxbpbxzxpwchiwtkroqisnmrbmefbmatmdknaklpgpyqlsccgunaibsloyqpnsibwuowebomrmcegejozypjzjunjmeygozcjqbnrpakdermjcckartbcppmbtkhkmmtcngteigjnxxyzaibtdcwutkvpwezisskfaeljmxyjwykwglqlnofhycwuivdbnpintuyhtyqpwaoelgpbuwiuyeqhbvkqlsfgmeoheexbhnhutxvnvfjwlzfmvpcghiowocdsjcvqrdmkcizxnivbianfpsnzabxqecinhgfyjrjlbikrrgsbgfgyxtzzwwpayapfgueroncpxogouyrdgzdfucfrywtywjeefkvtzxlwmrniselyeodysirqflpduvibfdvedgcrzpzrunpadvawfsmmddqzaaahfxlifobffbyzqqbtlcpquedzjvykvarayfldvmkapjcfzfbmhscdwhciecsbdledspgpdtsteuafzbrjuvmsfrajtulwirzagiqjdiehefmfifocadxfuxrpsemavncdxuoaetjkavqicgndjkkfhbvbhjdcygfwcwyhpirrfjziqonbyxhibelinpllxsjzoiifscwzlyjdmwhnuovvugfhvquuleuzmehggdfubpzolgbhwyeqekzccuypaspozwuhbzbdqdtejuniuuyagackubauvriwneeqfhtwkocuipcelcfrcjcymcuktegiikyosumeioatfcxrheklookaqekljtvtdwhxsteajevpjviqzudnjnqbucnfvkybggaybebljwcstmktgnipdyrxbgewqczzkaxmeazpzbjsntltjwlmuclxirwytvxgvxscztryubtjweehapvxrguzzsatozzjytnamfyiitreyxmanhzeqwgpoikcjlokebksgkaqetverjegqgkicsyqcktmwjwakivtsxjwrgakphqincqrxqhzbcnxljzwturmsaklhnvyungjrxaonjqomdnxpnvihmwzphkyuhwqwdboabepmwgyatyrgtboiypxfavbjtrgwswyvcqhzwibpisydtmltbkydhznbsvxktyfxopwkxzbftzknnwipghuoijrbgqnzovxckvojvsqqraffwowfvqvfcmiicwitrhxdeombgesxexedlakitfovtydxunqnwqqdeeekiwjnwoshqcsljiicgobbbuqakjdonjawgjlezdnqhfdqnmsuavxdpnfzwipmspiabveaarshzwxmirgkmfncvtdrdvfxkpxlkdokxgtwcskmjryyymcthfnkasinihaunohkxaibtsqelockaefjmsuolebtnepauwmrxutspjwaxbmahsjtkfkxlnszribmeofbkyvbjscjtqjakuwvcgunvnonvqbbggfshauqsyznokqbhowjusypfnecffenojfvlblgzntqzlrgzprvhqnpfrrkzxznieiuivajivzijsqijigtatifmbplzqahuidegfoobpymkputzamzvweiyvvzlwihgmmmrcburbgbsdxrfjsbiylitghgcpqjbevvgypxcybubyoijijrhuzcdijfybqbfowlookqmlnplbxvjjosfqviygqyhgamuwzjklbyzopkrnhbywtfoqomweldmlrhjqswctubiknzzvcztyehouvnyiqnvkufaobehxhrjvtisxjlxoumipzjarwvbsaegdkpbsjmpevjbewzuqnfhoohhmdjgfpmjzdmtmykqvtucptwfidpwtwffzolffzqfdearclkyeecuzabjeqhxpmfodsvisnpxrqowdawheydfyhoexvcmihdlzavtqlshdhdgjzpozvvackebhgqppvcrvymljfvooauxcjnbejdivikcoaugxwzsulgfqdtefpehbrlhaoqxwcancuvbqutnfbuygoemditeagmcveatgaikwflozgdhkyfqmjcruyyuemwbqwxyyfiwnvlmbovlmccaoguieu"
            , "cjgamyzjwxrgwedhsexosmswogckohesskteksqgrjonnrwhywxqkqmywqjlxnfrayykqotkzhxmbwvzstrcjfchvluvbaobymlrcgbbqaprwlsqglsrqvynitklvzmvlamqipryqjpmwhdcsxtkutyfoiqljfhxftnnjgmbpdplnuphuksoestuckgopnlwiyltezuwdmhsgzzajtrpnkkswsglhrjprxlvwftbtdtacvclotdcepuahcootzfkwqhtydwrgqrilwvbpadvpzwybmowluikmsfkvbebrxletigjjlealczoqnnejvowptikumnokysfjyoskvsxztnqhcwsamopfzablnrxokdxktrwqjvqfjimneenqvdxufahsshiemfofwlyiionrybfchuucxtyctixlpfrbngiltgtbwivujcyrwutwnuajcxwtfowuuefpnzqljnitpgkobfkqzkzdkwwpksjgzqvoplbzzjuqqgetlojnblslhpatjlzkbuathcuilqzdwfyhwkwxvpicgkxrxweaqevziriwhjzdqanmkljfatjifgaccefukavvsfrbqshhswtchfjkausgaukeapanswimbznstubmswqadckewemzbwdbogogcysfxhzreafwxxwczigwpuvqtathgkpkijqiqrzwugtr")
        );
    }

    public string MinWindow(string s, string t)
    {
        int patternLength = t.Length;
        int inputStringLength = s.Length;

        if (patternLength > inputStringLength)
        {
            return "";
        }

        Dictionary<char, int> pattern = new Dictionary<char, int>();
        for (int i = 0; i < patternLength; i++)
        {
            char patterChar = t[i];
            if (pattern.ContainsKey(patterChar))
            {
                pattern[patterChar]++;
                continue;
            }
            
            pattern.Add(patterChar, 1);
        }
        
        
        int leftPosition = 0;
        int rightPosition = 0;
        Dictionary<char, int> lettersFound = new Dictionary<char, int>();
        int minLength = int.MaxValue;
        string minMatch = "";
        
        while (rightPosition < inputStringLength)
        {
            char rightLetter = s[rightPosition];
            if (CanAdd(rightLetter, lettersFound, pattern))
            {
                AddToFound(rightLetter, lettersFound);
            }

            while (AllCharactersFound(lettersFound, pattern) && leftPosition < inputStringLength - patternLength)
            {
                int currentWindowLength = rightPosition - leftPosition;
                if (currentWindowLength < minLength)
                {
                    minLength = currentWindowLength;
                    minMatch = s.Substring(leftPosition, currentWindowLength);
                }
                
                char leftLetter = s[leftPosition];
                if (CanRemove(leftLetter, lettersFound))
                {
                    RemoveFromFound(leftLetter, lettersFound);
                }

                leftPosition++;
            }
            
            rightPosition++;
        }

        return minMatch;
    }

    private void RemoveFromFound(char leftLetter, Dictionary<char, int> lettersFound)
    {
        lettersFound[leftLetter]--;
    }

    private bool CanRemove(char leftLetter, Dictionary<char, int> lettersFound)
    {
        return lettersFound.ContainsKey(leftLetter) == true && lettersFound[leftLetter] > 0;
    }

    private bool AllCharactersFound(Dictionary<char, int> lettersFound, Dictionary<char, int> pattern)
    {
        foreach (KeyValuePair<char, int> keyValue in pattern)
        {
            if (lettersFound.ContainsKey(keyValue.Key) == false)
            {
                return false;
            }

            if (lettersFound[keyValue.Key] < keyValue.Value)
            {
                return false;
            }
        }
        
        return true;
    }

    private void AddToFound(char rightLetter, Dictionary<char, int> lettersFound)
    {
        if (lettersFound.ContainsKey(rightLetter))
        {
            lettersFound[rightLetter]++;
            return;
        }
        lettersFound.Add(rightLetter, 1);
    }

    private bool CanAdd(char rightLetter, Dictionary<char, int> lettersFound, Dictionary<char, int> pattern)
    {
        return pattern.ContainsKey(rightLetter) &&
               (!lettersFound.ContainsKey(rightLetter) || lettersFound[rightLetter] < pattern[rightLetter]);
    }

    /*public string MinWindow(string s, string t)
    {
        int tLength = t.Length;
        int sLength = s.Length;

        if (tLength > sLength)
        {
            return "";
        }

        for (int frameLength = tLength; frameLength <= sLength; frameLength++)
        {
            for (int i = 0; i <= s.Length - frameLength; i++)
            {
                string subString = s.Substring(i, frameLength);
                if (HasAllLetters(subString, t))
                {
                    return subString;
                }
            }
        }


        return "";
    }

    private bool HasAllLetters(string InputString, string lettersToHave)
    {
        Dictionary<char, int> lettersInQueryString = new Dictionary<char, int>();
        for (int i = 0; i < InputString.Length; i++)
        {
            char letter = InputString[i];
            if (lettersInQueryString.Keys.Contains(letter)){
                lettersInQueryString[letter]++;
            }
            else
            {
                lettersInQueryString.Add(letter, 1);
            }
        }

        for (int i = 0; i < lettersToHave.Length; i++)
        {
            char letterToHave = lettersToHave[i];
            if (lettersInQueryString.Keys.Contains(letterToHave) == false 
                || lettersInQueryString[letterToHave] <= 0)
            {
                return false;
            }

            lettersInQueryString[letterToHave]--;
        }

        return true;
    }*/
}
