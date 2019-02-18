using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CreateSerializableClass
{
    public partial class Form1 : Form
    {
        private List<string> SelectedDataTypes = new List<string>();
        public Form1()
        {
            InitializeComponent();

            //If del is pressed, delete selected Item from List
            ListOfUsings.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Delete)
                {
                    ListOfUsings.Items.Remove(ListOfUsings.SelectedItem);
                }
            };

            ListConstructorParams.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Delete)
                {
                    ListConstructorParams.Items.Remove(ListConstructorParams.SelectedItem);
                }
            };

            ListContructors.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Delete)
                {
                    ListContructors.Items.Remove(ListContructors.SelectedItem);
                }
            };

            ListOfProperties.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Delete)
                {
                    ListOfProperties.Items.Remove(ListOfProperties.SelectedItem);

                    SelectedDataTypes.Remove(SelectedDataTypes.Last());

                    if (ListOfProperties.Items.Count == 0)
                    {
                        ListConstructorParams.Items.Clear();
                        ListContructors.Items.Clear();
                        ComboConstructor.Text = "";
                        SelectedDataTypes.Clear();
                        ComboConstructor.Items.Clear();
                        ComboConstructor.Enabled = false;
                        ConstructorBox.Enabled = false;
                        CreateFileBtn.Enabled = false;
                        CreateConstructorBtn.Enabled = false;
                    }
                }
            };

            ComboUsings.SelectedIndexChanged += (sender, args) => { ListOfUsings.Items.Add(ComboUsings.SelectedItem); };

            PropertyName.KeyDown += (sender, args) =>
            {
                if (!string.IsNullOrWhiteSpace(ComboAccessModifier.Text) && !string.IsNullOrWhiteSpace(ComboDatatype.Text) && !string.IsNullOrWhiteSpace(PropertyName.Text) && args.KeyCode == Keys.Enter)
                {
                    ComboAccessModifier.Focus();
                    ListOfProperties.Items.Add(ComboAccessModifier.SelectedItem + " " + ComboDatatype.SelectedItem + " " + PropertyName.Text.First().ToString().ToUpper()+PropertyName.Text.Substring(1) + " {get;set;}");
                    SelectedDataTypes.Add(ComboDatatype.SelectedItem + " " + PropertyName.Text);

                    if (ListOfProperties.Items.Count >= 1)
                    {
                        PropertyAddCalled.Checked = true;
                    }

                    if (ListOfProperties.Items.Count != 0 && PropertyAddCalled.Checked)
                    {
                        UpdateComboConstructor();
                    }

                    CreateConstructorBtn.Enabled = true;
                    CreateFileBtn.Enabled = true;
                    PropertyName.Text = "";
                    ComboAccessModifier.Text = "";
                    ComboDatatype.Text = "";
                }
            };

            ComboConstructor.SelectedIndexChanged += (sender, args) =>
            {
                ListConstructorParams.Items.Add(ComboConstructor.SelectedItem);
            };

            ClassName.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrWhiteSpace(ClassName.Text) && !string.IsNullOrWhiteSpace(NamespaceName.Text))
                    {
                        this.ClassName.Text = this.ClassName.Text.First().ToString().ToUpper() +
                                              this.ClassName.Text.Substring(1);
                        PropertyBox.Enabled = true;
                        this.ClassName.Enabled = false;
                        this.NamespaceName.Enabled = false;
                    }
                    else
                    {
                        PropertyBox.Enabled = false;
                    }
                }
                else
                {
                    PropertyBox.Enabled = false;
                }
            };

            ComboDatatype.TextChanged += (sender, args) =>
            {
                PropertyName.Enabled = !string.IsNullOrWhiteSpace(ComboDatatype.Text);
            };
        }

        private void UpdateComboConstructor()
        {
            ComboConstructor.Items.Clear();
            ComboConstructor.Enabled = true;
            ConstructorBox.Enabled = true;
            foreach (string dataType in SelectedDataTypes)
            {
                ComboConstructor.Items.Add(dataType.First().ToString().ToLower()+dataType.Substring(1));
            }
        }

        private void CreateConstructorBtn_Click(object sender, EventArgs e)
        {
            string listOfParams = string.Empty;
            int counter = ListConstructorParams.Items.Count;
            int counterTwo = 1;
            foreach (object item in ListConstructorParams.Items)
            {
                listOfParams += item.ToString();
                if (counterTwo < counter)
                {
                    counterTwo++;
                    listOfParams += ", ";
                }
            }

            string settingProperties = string.Empty;
            foreach (string property in ListConstructorParams.Items)
            {
                string[] tempArray = property.Split(' ');
                string useMe = tempArray[1];
                settingProperties += "this." + useMe.First().ToString().ToUpper()+useMe.Substring(1) + " = "+tempArray[1]+";\n";
            }

            ListConstructorParams.Items.Clear();

            ListContructors.Items.Add("public " + ClassName.Text+"("+listOfParams+"){"+settingProperties+"}");
        }

        private void CreateFileBtn_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+ClassName.Text+".cs");
            string final = string.Empty;

            final += "//This Code was automatically generated through 'CreateSerializableClass'\n";
            final += "//The Programm was created by ArturB\n";
            final += "//For further help or requests contact ArturB\n\n";

            foreach (string @using in ListOfUsings.Items)
            {
                final += @using+"\n";
            }

            final += "using System.Xml.Serialization;\n";
            final += "\nnamespace "+NamespaceName.Text + "\n{\n";
            final += "[XmlRoot()]";
            final += "\npublic class "+ClassName.Text + "\n{\n";

            foreach (string property in ListOfProperties.Items)
            {
                final += "[XmlElement()]";
                final += "\n" + property+"\n";
            }

            foreach (string item in ListContructors.Items)
            {
                final += "\n" + item+"\n";
            }

            final += "\npublic " + ClassName.Text + " ()\n{\n\n}";
            final += "\n}\n";
            final += "\n}";

            writer.WriteAsync(final);
            writer.Flush();
            writer.Close();

            //Reset all
            this.ConstructorBox.Enabled = false;
            this.PropertyBox.Enabled = false;
            this.ClassName.Enabled = true;
            this.NamespaceName.Enabled = true;
            this.ListOfProperties.Items.Clear();
            this.ListContructors.Items.Clear();
            this.ListOfUsings.Items.Clear();
            this.SelectedDataTypes.Clear();
            this.ClassName.Clear();
            this.NamespaceName.Text = "Program";
            this.ComboUsings.ResetText();
        }
    }
}
