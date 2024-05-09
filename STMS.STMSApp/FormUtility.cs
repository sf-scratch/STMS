using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.STMSApp
{
    public static class FormUtility
    {
        public static bool CheckOpenForm(Type formType)
        {
            bool result = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().FullName == formType.FullName)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public static Form GetOpenForm(Type formType)
        {
            Form result = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().FullName == formType.FullName)
                {
                    result = form;
                    break;
                }
            }
            return result;
        }

        public static void AddPanelForm(this Panel panel, Type formType)
        {
            if (formType.IsSubclassOf(typeof(Form)))
            {
                Form tempForm = null;
                if (CheckOpenForm(formType))
                {
                    bool show = false;
                    Form openForm = GetOpenForm(formType);
                    foreach (Control control in panel.Controls)
                    {
                        if (control is Form)
                        {
                            Form cForm = (Form)control;
                            if (cForm.Name == openForm.Name)
                            {
                                tempForm = cForm;
                                show = true;
                                break;
                            }
                        }
                    }
                    if (!show)
                    {
                        tempForm = openForm;
                    }
                }

                if (tempForm == null)
                {
                    tempForm = (Form)Activator.CreateInstance(formType);
                    tempForm.TopLevel = false;
                    tempForm.WindowState = FormWindowState.Maximized;
                    tempForm.FormBorderStyle = FormBorderStyle.None;
                    tempForm.Dock = DockStyle.Fill;
                }
                panel.Controls.Clear();
                panel.AutoScroll = true;
                panel.Controls.Add(tempForm);
                tempForm.Show();
            }
        }
    }
}
