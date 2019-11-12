using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][,] JGinter = new string[6][,]
            {
                new string[,]{
                
                    {"Afghanistan","Kabul" }
                    ,{"Armenia","Yerevan"}
                    ,{"Azerbaijan","Baku"}
                    ,{"Bahrain","Manama"}
                    ,{"Bangladesh","Dhaka"}
                    ,{"Bhutan","Thimphu"}
                    ,{"Brunei","Bandar Seri Begawan"}
                    ,{"Cambodia","Phnom Penh"}
                    ,{"China","Beijing"}
                    ,{"Cyprus","Nicosia"}
                    ,{"Georgia","Tbilisi"}
                    ,{"India","New Delhi"}
                    ,{"Indonesia","Jakarta"}
                    ,{"	Iraq","Baghdad"}
                    ,{"Israel","Jerusalem"}
                    ,{"Iran","Tehran"}
                    ,{"Jordan","Amman"}
                    ,{"Japan","Tokyo"}
                    ,{"Kazakhstan","Nur-Sultan"}
                    ,{"Kyrgyzstan","Bishkek"}
                    ,{"Kuwait","Kuwait City"}
                    ,{"	Laos","Vientiane"}
                    ,{"Lebanon","	Beirut"}
                    ,{"Myanmar","Nay Pyi Taw"}
                    ,{"Mongolia","Ulan Bator"}
                    ,{"Maldives","Malé"}
                    ,{"	Malaysia","	Kuala Lumpur"}
                    ,{"	North Korea","Pyongyang"}
                    ,{"Nepal","Kathmandu"}
                    ,{"	Oman","	Muscat"}
                    ,{"Pakistan","Islamabad"}
                    ,{"Palestine","Jerusalem"}
                    ,{"	Philippines","Manila"}
                    ,{"	Qatar","Doha"}
                    ,{"South Korea","	Seoul"}
                     ,{"Saudi Arabia","Riyadh"}
                    ,{"Syria","Damascus"}
                    ,{"Sri Lanka","Sri Jayawardenepura Kotte"}
                    ,{"Singapore","Singapore"}
                    ,{"Timor-Leste","	Dili"}
                     ,{"Turkey","Ankara"}
                    ,{"Turkmenistan","	Ashgabat"}
                    ,{"Tajikistan","	Dushanbe"}
                    ,{"	Thailand","Bangkok"}
                    ,{"	Uzbekistan","Tashkent"}
                     ,{"United Arab Emirates","Abu Dhabi"}
                    ,{"Vietnam","Hanoi"}
                    ,{"	Yemen","Sana’a"}
                    

                },

                 new string[,]{
                      {"Australia","Canberra"}
                    ,{"	Fiji","	Suva"}
                    ,{"Kiribati","Tarawa"}
                    ,{"	Micronesia","Palikir"}
                    ,{"Marshall Islands","	Majuro"}
                    ,{"Nauru","–"}
                     ,{"New Zealand","Wellington"}
                     ,{"Papua New Guinea","Port Moresby"}
                    ,{"Palau","Melekeok"}
                    ,{"	Samoa","Apia"}
                    ,{"	Solomon Islands","Honiara"}
                    ,{"Tuvalu","Funafuti"}
                    ,{"Vanuatu","	Port Vila"}
                    ,{"Tonga","	Nukuʻalofa"}
                    
                },
                   new string[,]{
                    {"Greece","Athens"}
                    ,{"Kosovo","Pristina"}
                    ,{"	Croatia","Zagreb"}
                    ,{"Czechia","Prague"}
                    ,{"	San Marino","San Marino"}
                    ,{"Serbia","Belgrade"}
                    ,{"Denmark","Copenhagen"}
                    ,{"Vatican City State","Vatican"}
                    ,{"	North Macedonia","Skopje"}
                    ,{"Norway","Oslo"}
                    ,{"	Netherlands","	Amsterdam"}
                    ,{"Bosnia and Herzegovina","Sarajevo"}
                    ,{"	Bulgaria","Sofia"}
                    ,{"Belgium","Brussels"}
                    ,{"	Belarus","	Minsk"}
                    ,{"	Portugal","	Lisbon"}
                    ,{"Poland","	Warsaw"}
                    ,{"	France","Paris"}
                    ,{"Montenegro","	Podgorica"}
                    ,{"	Moldova","	Chișinău"}
                    ,{"Malta","	Valletta"}
                    ,{"Monaco","	Monaco"}
                    ,{"	Ukraine","Kiev"}
                    ,{"Germany","Berlin"}
                    ,{"	Russia","	Moscow"}
                    ,{"	Romania","	Bucharest"}
                    ,{"Luxembourg","	Luxembourg"}
                    ,{"	Latvia","	Riga"}
                    ,{"Liechtenstein","	Vaduz"}
                    ,{"Lithuania","	Vilnius"}
                    ,{"Spain","	Madrid"}
                    ,{"	Slovakia","	Bratislava"}
                    ,{"Slovenia","	Ljubljana"}
                    ,{"Switzerland","	Bern"}
                    ,{"	Sweden","	Stockholm"}
                    ,{"United Kingdom","	London"}
                    ,{"Austria","Vienna"}
                     ,{"Andorra","	Andorra la Vella"}
                    ,{"	Italy","Rome"}
                    ,{"	Estonia","	Tallinn"}
                    ,{"	Albania","	Tirana"}
                    ,{"Iceland","Reykjavík"}
                    ,{"Ireland","Dublin"}
                    ,{"Hungary","	Budapest"}
                    
                },
                     new string[,]{

                    
                   
                    {"Ghana","Accra"}
                    ,{"	Gabon","	Libreville"}
                    ,{"	Cabo Verde","	Praia"}
                    ,{"	Guinea","	Conakry"}
                    ,{"Guinea-Bissau","	Bissau"}
                    ,{"	The Gambia","	Banjul"}
                    ,{"Côte d’Ivoire","	Yamoussoukro"}
                    ,{"	Comoros","Moroni"}
                    ,{"Kenya","Nairobi"}
                    ,{"Cameroon","Yaoundé"}
                    ,{"Djibouti","	Djibouti"}
                    ,{"	Chad","N’Djamena"}
                    ,{"Zimbabwe","	Harare"}
                    ,{"	Sudan","Khartoum"}
                    ,{"Seychelles","	Victoria"}
                    ,{"Senegal","	Dakar"}
                    ,{"São Tomé and Príncipe","	São Tomé"}
                    ,{"South Sudan","	Juba"}
                    ,{"Sierra Leone","Freetown"}
                    ,{"	Zambia","	Lusaka"}
                    ,{"	Somalia","	Mogadishu"}
                    ,{"	Tunisia","	Tunis"}
                    ,{"	Togo","	Lomé"}
                    ,{"Tanzania","	Dodoma"}
                    ,{"Namibia","	Windhoek"}
                    ,{"Nigeria","	Abuja	"}
                    ,{"	Niger	","	Niamey"}
                    ,{"	Botswana","	Gaborone"}
                    ,{"	Burundi","	Gitega"}
                    ,{"	Burkina Faso","	Ouagadougou"}
                    ,{"Benin","	Porto-Novo"}
                    ,{"	Mauritius","	Port Louis"}
                    ,{"	Mauritania","	Nouakchott"}
                    ,{"	Madagascar","	Antananarivo"}
                    ,{"	Malawi","	Lilongwe"}
                    ,{"	Mali","Bamako"}
                    ,{"Mozambique","Maputo"}
                    ,{"Morocco","	Rabat"}
                    ,{"Uganda","Kampala"}
                    ,{"Rwanda","Kigali"}
                    ,{"	Libya","Tripoli"}
                    ,{"	Lesotho","	Maseru"}
                    ,{"Liberia","	Monrovia"}
                    ,{"	Republic of the Congo","Brazzaville"}
                    ,{"Democratic Republic of the Congo","	Kinshasa"}
                    ,{"	Central African Republic","	Bangui"}
                    ,{"Equatorial Guinea","	Malabo"}
                    ,{"Egypt","Cairo"}
                    ,{"Ethiopia","	Addis Ababa"}
                    ,{"	Eritrea","Asmara"}
                    ,{"	Eswatini","	Mbabane"}
                    ,{"Angola","	Luanda"}
                    ,{"South Africa","	Pretoria"}
                    ,{"Algeria","Algiers"}
                   
                },
                       new string[,]{

                    {"	Guatemala","Guatemala City"}
                    ,{"	Grenada","Saint George’s"}
                    ,{"Costa Rica","	San José"}
                    ,{"	Cuba","	Havana"}
                    ,{"	Canada","Ottawa"}
                    ,{"	Jamaica","	Kingston"}
                    ,{"Saint Kitts and Nevis","	Basseterre"}
                    ,{"	Saint Lucia","Castries"}
                    ,{"Saint Vincent and the Grenadines","	Kingstown"}
                    ,{"Dominica","	Roseau"}
                    ,{"	Nicaragua","Managua"}
                    ,{"	Barbados","Bridgetown"    }
                    ,{"Bahamas","	Nassau"}
                    ,{"	Belize","Belmopan"}
                    ,{"	Panama","	Panama City"}
                    ,{"	Mexico","Mexico City"}
                    ,{"United States","Washington, D.C."}
                    ,{"	Dominican Republic","	Santo Domingo"}
                    ,{"	El Salvador","	San Salvador"}
                    ,{"	Antigua and Barbuda","	Saint John’s"}
                    ,{"Honduras","	Tegucigalpa"}
                    ,{"	Haiti","	Port-au-Prince"}
                    
                },
                         new string[,]{
                        {"	Guyana","Georgetown"}
                    ,{"	Colombia","Bogotá"}
                    ,{"Chile","	Santiago"}
                     ,{"Suriname","Paramaribo"}
                    ,{"	Trinidad and Tobago","Port of Spain"}
                     ,{"	Brazil","	Brasília"}
                    ,{"	Bolivia","	Sucre"}
                     ,{"	Paraguay","Asunción"}
                    ,{"	Peru","Lima"}
                     ,{"	Venezuela","Caracas"}
                    ,{"	Argentina","	Buenos Aires"}
                     ,{"	Uruguay","Montevideo"}
                    ,{"	Ecuador","	Quito"}
                    
                },
             };
            for (int row = 0, cnt = 0; row < JGinter.GetLength(0); row++, cnt++)
            {
                switch (cnt)
                {
                    case 0:
                        Console.WriteLine("Asia");
                        break;
                    case 1:
                        Console.WriteLine("Oceania");
                        break;
                    case 2:
                        Console.WriteLine("Europe");
                        break;
                    case 3:
                        Console.WriteLine("Africa");
                        break;
                    case 4:
                        Console.WriteLine("North America");
                        break;
                    case 5:
                        Console.WriteLine("South America");
                        break;
                }
                //Console.WriteLine(row);
                for (int col = 0; col < JGinter[row].GetLength(0); col++)
                {
                    //Console.WriteLine(col);
                    for (int index = 0; index < JGinter[row].GetLength(1); index++)
                    {
                        Console.WriteLine("{0}{1}", index == 0 ? "Country : " : "City : ", JGinter[row][col, index]);
                    }
                    Console.WriteLine();


                }
                Console.ReadLine();
            }        
            
        }
    }
}
                

    

