using System.Xml;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 图像处理
{
    public class OperateXml
    {                
        public static List<string> getAllXml()
        {
            string status = "";
            string xmlPath = @"setting.xml";
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fullName = fullName.Substring(0, fullName.LastIndexOf("\\")) + "\\" + xmlPath;            
            XmlDocument doc = new XmlDocument();
            doc.Load(fullName);
            XmlNode xn = doc.SelectSingleNode("Settings");
            XmlNodeList xnl = null;
            xnl = xn.SelectNodes("/Settings/Setting/status");
            List<string> list = new List<string>();
            foreach (XmlNode xn1 in xnl)
            {
                status = xn1.InnerText;
                list.Add(status);
            }
            return list;
        }
        public static void modifyXml(string[] StrArr)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string haarXmlPath = @"setting.xml";
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fullName = fullName.Substring(0, fullName.LastIndexOf("\\")) + "\\" + haarXmlPath;

            xmlDoc.Load(fullName);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Settings").ChildNodes;//获取bookstore节点的所有子节点
            foreach (XmlNode xn in nodeList)//遍历所有子节点
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型
                if (xe.GetAttribute("ID") == "1" && StrArr[0].ToString()!="")
                {
                    XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点
                    foreach (XmlNode xn1 in nls)//遍历
                    {
                        XmlElement xe2 = (XmlElement)xn1;//转换类型
                        if (xe2.Name == "status")//如果找到
                        {
                            xe2.InnerText = StrArr[0].ToString();//则修改
                            
                        }
                    }

                    
                }
                else if (xe.GetAttribute("ID") == "2" && StrArr[1].ToString() != "")
                {
                    XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点
                    foreach (XmlNode xn1 in nls)//遍历
                    {
                        XmlElement xe2 = (XmlElement)xn1;//转换类型
                        if (xe2.Name == "status")//如果找到
                        {
                            xe2.InnerText = StrArr[1].ToString();//则修改
                                                       
                        }
                    }
                }
                else if (xe.GetAttribute("ID") == "3" && StrArr[2].ToString() != "")
                {
                    XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点
                    foreach (XmlNode xn1 in nls)//遍历
                    {
                        XmlElement xe2 = (XmlElement)xn1;//转换类型
                        if (xe2.Name == "status")//如果找到
                        {
                            xe2.InnerText = StrArr[2].ToString();//则修改
                        }
                    }
                }
                else if (xe.GetAttribute("ID") == "4" && StrArr[3].ToString() != "")
                {
                    XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点
                    foreach (XmlNode xn1 in nls)//遍历
                    {
                        XmlElement xe2 = (XmlElement)xn1;//转换类型
                        if (xe2.Name == "status")//如果找到
                        {
                            xe2.InnerText = StrArr[3].ToString();//则修改
                        }
                    }
                }
                xmlDoc.Save(fullName);//保存。
            }
        }
       
    }
}