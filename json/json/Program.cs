using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    public static string Prefield = "<field name=";
    public static string EndField = "</field>";
    public static int first;
    static void Main()
    {
        StringBuilder sData = new StringBuilder();
        var json = @"{
  'Application Details': {
    'Loan Type': 'Takeover',
    'Application Date': '2023-09-01T11:04:47.583Z',
    'Branch': 'Thimphu Main Branch'
  },
  'Applicant Personal Details': {
                        'Title': 'Mr.',
    'Name': 'shubham suresh Asabe',
    'Nationality': 'Bhutanese',
    'CID NO': '32543543',
    'Work Permit Number': '3456456',
    'Gender': 'Male',
    'Date of Birth': '1998-05-12T18:30:00.000Z',
    'Savings Account Number': '2374632476',
    'Tax Payer Number (TPN)': '234238647',
    'Martial Status': 'Single',
    'Spouse Name': '',
    'Spouse CID No.': '',
    'Co-Applicant': 'Yes',
    'Guarantor': 'Yes',
    'Co-Applicant Personal Details': [
      {
        'Title': 'Mr.',
        'Name': 'Rohit Patil',
        'Nationality': 'Non-Bhutanese',
        'CID NO': '32423423',
        'Work Permit Number': '2342543',
        'Gender': 'Male',
        'Date of Birth': '1997-08-06T18:30:00.000Z',
        'Savings Account Number': '324324324',
        'Tax Payer Number (TPN)': '234234324',
        'Martial Status': 'Single',
        'Spouse Name': '',
        'Spouse CID No.': ''
      },
      {
        'Title': 'Miss.',
        'Name': 'Mohan Mohar',
        'Nationality': 'Non-Bhutanese',
        'CID NO': '3242342',
        'Work Permit Number': '3234324',
        'Gender': 'Female',
        'Date of Birth': '1999-05-04T18:30:00.000Z',
        'Savings Account Number': '354534',
        'Tax Payer Number (TPN)': '534534534',
        'Martial Status': 'Single',
        'Spouse Name': '',
        'Spouse CID No.': ''
      }
    ],
    'Gurantor Personal Details': [
      {
        'Title': 'Mr.',
        'Name': 'Kapil sharma',
        'Nationality': 'Non-Bhutanese',
        'CID NO': '2423423',
        'Work Permit Number': '234324',
        'Gender': 'Male',
        'Date of Birth': '2000-08-08T18:30:00.000Z',
        'Savings Account Number': '23432423423',
        'Tax Payer Number (TPN)': '23432432',
        'Martial Status': 'Married',
        'Spouse Name': 'Vijay',
        'Spouse CID No.': '3543534534'
      },
      {
        'Title': 'Mr.',
        'Name': 'Krishan More',
        'Nationality': 'Non-Bhutanese',
        'CID NO': '234324',
        'Work Permit Number': '234532',
        'Gender': 'Male',
        'Date of Birth': '1996-08-20T18:30:00.000Z',
        'Savings Account Number': '234234',
        'Tax Payer Number (TPN)': '23423432',
        'Martial Status': 'Married',
        'Spouse Name': 'Parth',
        'Spouse CID No.': '435345345'
      }
    ]
  },
  'Communication Details': {
    'Village': 'Kirkhorthang',
    'Contact No.': '34324',
    'Email ID': 'shubham.asabe@careedge.in',
    'Gewog': 'Gesarling',
    'Dzongkhag': 'Dagana',
    'Present Address': '',
    'Permanent Address': '',
    'Thram No.': '324',
    'House No': '23',
    'Co-Applicant Communication Details': [
      {
        'Village': 'Kirkhorthang',
        'Contact No.': '43543565',
        'Email ID': 'rohit45@gmail.com',
        'Gewog': 'Tseza',
        'Dzongkhag': 'Tsirang',
        'Present Address': '',
        'Permanent Address': '',
        'Thram No.': '23423',
        'House No': '43'
      },
      {
        'Village': 'Kirkhorthang',
        'Contact No.': '23423',
        'Email ID': 'kp123@gmail.com',
        'Gewog': 'Tseza',
        'Dzongkhag': 'Tsirang',
        'Present Address': '',
        'Permanent Address': '',
        'Thram No.': '32432',
        'House No': '23423'
      }
    ],
    'Gurantor Communication Details': [
      {
        'Village': 'Gesarling',
        'Contact No.': '324324',
        'Email ID': 'abc@gmail.com',
        'Gewog': 'Gesarling',
        'Dzongkhag': 'Tsirang',
        'Present Address': 'B03',
        'Permanent Address': '',
        'Thram No.': '42535',
        'House No': '435'
      },
      {
        'Village': 'Gesarling',
        'Contact No.': '345435',
        'Email ID': 'shubham@careedge.in',
        'Gewog': 'Tseza',
        'Dzongkhag': 'Tsirang',
        'Present Address': '',
        'Permanent Address': '',
        'Thram No.': '32432',
        'House No': '234'
      }
    ]
  },
  'Employment Details': {
    'Occupation Type': 'Civil Servent',
    'Employee ID': '2343546',
    'Monthly Gross Salary': 80000,
    'Nature of Service': 'Regular',
    'Salary Payment': 'e-PEMS',
    'PF and Gratuty': 'Yes',
    'Designation': 'Developer',
    'Grade': 'A2',
    'Department': 'IT',
    'Ministry / Agency': 'INdia',
    'Contract Years': '2',
    'Co-Applicant Employment Details': [
      {
        'Occupation Type': 'NGO',
        'Employee ID': '123245',
        'Monthly Gross Salary': 50000,
        'Nature of Service': 'Contract',
        'Salary Payment': 'e-PEMS',
        'PF and Gratuty': 'Yes',
        'Designation': 'Team Lead',
        'Grade': 'A2',
        'Department': 'Social',
        'Ministry / Agency': 'India',
        'Contract Years': '2'
      },
      {
        'Occupation Type': 'Corporate',
        'Employee ID': '234324',
        'Monthly Gross Salary': 60000,
        'Nature of Service': 'Regular',
        'Salary Payment': 'Non e-PEMS',
        'PF and Gratuty': 'Yes',
        'Designation': 'Tester',
        'Grade': 'A2',
        'Department': 'Testing',
        'Ministry / Agency': 'India',
        'Contract Years': '1'
      }
    ],
    'Gurantor Employment Details': [
      {
        'Occupation Type': 'Civil Servent',
        'Employee ID': '3454',
        'Monthly Gross Salary': 45000,
        'Nature of Service': 'Regular',
        'Salary Payment': 'e-PEMS',
        'PF and Gratuty': 'Yes',
        'Designation': 'Head',
        'Grade': 'A2',
        'Department': 'Tech ',
        'Ministry / Agency': 'India',
        'Contract Years': '2'
      },
      {
        'Occupation Type': 'Civil Servent',
        'Employee ID': '21312',
        'Monthly Gross Salary': 70000,
        'Nature of Service': 'Contract',
        'Salary Payment': 'e-PEMS',
        'PF and Gratuty': 'Yes',
        'Designation': 'Delivery head',
        'Grade': 'A4',
        'Department': 'Functional',
        'Ministry / Agency': 'India',
        'Contract Years': '2'
      }
    ]
  },
  'Loan Details': {
    'Loan Purpose': 'Consumer Loan',
    'Tenure': 60,
    'Loan Amount': 880000,
    'Interest Rate': 11
  }
}";



        if(json is string)
        {

        }
        var jToken = JToken.Parse(json);

        Generatexml(jToken,sData);
        var k = sData.ToString();
    }

    static void Generatexml(JToken token, StringBuilder sData, string parentName = null, int? childElementcount = null, int? arrayElementcount = null)
    {
        if (token is JValue jValue)
        {
            //this line is for getting path in case you need it.
            var getpath = Regex.Matches(jValue.Path, @"\['(.*?)'\]");
            string path = getpath[getpath.Count - 1].Groups[1].Value;
            if (arrayElementcount !=null)
            {
                StringBuilder sb = new StringBuilder();
                for(int i=1;i<=arrayElementcount; i++)
                {
                    sb.Append(i+" ");
                }
                sData.Append(Prefield).Append("\"").Append(path).Append("\">").Append(sb.ToString()).Append(" ");
            }

            if (childElementcount != null)
            {
                if (childElementcount == 1)
                {
                    for (int arrayElementcnt = 1; arrayElementcnt <= arrayElementcount; arrayElementcnt++)
                    {
                        if (arrayElementcnt == 1)
                            sData.Append(Prefield).Append("\"").Append(path).Append("\">").Append(arrayElementcnt).Append(" ");
                        else if (arrayElementcnt > 1)
                            sData.Append(arrayElementcnt).Append(" ");



                        if (arrayElementcnt == arrayElementcount)
                        {
                            sData.Append(EndField);
                            sData.AppendLine();
                        }
                    }
                }
                sData.Append(Prefield).Append("\"").Append(path).Append("\\").Append(childElementcount).Append("\\").Append(parentName).Append("\">").Append(jValue.Value).Append(EndField);
                sData.AppendLine();



            }
            else
            {
                sData.Append(Prefield).Append("\"").Append(path).Append("\\").Append(parentName).Append("\">").Append(jValue.Value).Append(EndField);
            }
            //sData.Append(Prefield).Append("\"").Append(path).Append("\\").Append(parentName).Append("\">").Append(jValue.Value).Append(EndField);
            sData.AppendLine();
        }
        else if (token is JObject jObject)
        {
            foreach (var property in jObject.Properties())
            {
                Generatexml(property.Value, sData, property.Name, childElementcount, arrayElementcount);
            }
        }
        else if (token is JArray jArray)
        {
            arrayElementcount = jArray.Count;
            for (int i = 0; i < jArray.Count; i++)
            {
                Generatexml(jArray[i], sData, $"{parentName}[{i}]", i + 1, arrayElementcount);
            }
        }
    }





    //public static StringBuilder GetSiblings(JProperty childToken, StringBuilder strBuilder)
    //{
    //    JProperty ctoken = childToken;
    //    var ctokenval = ctoken.Value;
    //    foreach (var jsibling in ctokenval.Children<JProperty>())
    //    {
    //        strBuilder.Append(Prefield).Append("\"").Append(jsibling.Name).Append("\">").Append(jsibling.Value).Append(EndField);
    //    }



    //    if ((JProperty)ctokenval.Next != null)
    //    {
    //        JProperty ctokensibling = (JProperty)ctokenval.Next;
    //        var ctokensiblingval = ctokensibling.Value;
    //        GetSiblings(ctokensibling, strBuilder);
    //    }
    //    return strBuilder;

    static void PrintKeysAndValues(JToken token, StringBuilder sData, string parentName = null)
    {
        if (token is JValue jValue)
        {
            //Console.WriteLine($"{parentName}: {jValue.Value}");
            var getpath = Regex.Matches(jValue.Path, @"\['(.*?)'\]");
            var lastpath = getpath[getpath.Count - 1].Value;

            sData.Append(Prefield).Append("\"").Append(getpath[0].Groups[1].Value + getpath[0].Groups[1].Value).Append("\\").Append(parentName).Append("\">").Append(jValue.Value).Append(EndField);

            sData.AppendLine();


        }
        else if (token is JObject jObject)
        {
            foreach (var property in jObject.Properties())
            {
                PrintKeysAndValues(property.Value, sData, property.Name);
            }
        }
        else if (token is JArray jArray)
        {
            for (int i = 0; i < jArray.Count; i++)
            {
                PrintKeysAndValues(jArray[i], sData, $"{parentName}[{i}]");
            }
        }
    }


}

