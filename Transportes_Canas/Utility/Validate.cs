using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportes_Canas.Utility
{
    public class Validate
    {
        private ErrorProvider EpForm;
        public Validate(ErrorProvider EpForm)
        {
            this.EpForm = EpForm;
        }

        public bool ValidateString(TextBox txtControl, string msg)
        {
            if (txtControl.Text.Trim().Length == 0)
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
            else
            {
                return  true;
            }
        }

        public bool ValidatePositiveNumber(ComboBox cmb, string msg)
        {
            if (cmb.SelectedValue != null)
            {
                if (Int16.Parse(cmb.SelectedValue.ToString()) > 0)
                {

                    return true;
                }
                else
                {
                    EpForm.SetError(cmb, msg);
                    return false;
                }
            }
            else
            {
                EpForm.SetError(cmb, msg);
                return false;
            }
        }

        public bool ValidateDui(MaskedTextBox txtControl, string msg)
        {
            Regex rx = new Regex(@"^[0-9]{8}-{0,1}[0-9]{1}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!rx.IsMatch(txtControl.Text))
            {
                EpForm.SetError(txtControl, msg);
                return false;
            } else
            {
                return true;
            }
        }

        public bool ValidateNitOrLicense(MaskedTextBox txtControl, string msg)
        {
            Regex rx = new Regex(@"^[0-9]{4}-{1}[0-9]{6}-{1}[0-9]{3}-{1}[0-9]{1}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!rx.IsMatch(txtControl.Text))
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatePassport(MaskedTextBox txtControl, string msg)
        {
            Regex rx = new Regex(@"^[A-Z]{1}[0-9]{8}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!rx.IsMatch(txtControl.Text))
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateTelephoneSV(MaskedTextBox txtControl, string msg)
        {
            Regex rx = new Regex(@"^[0-9]{4}-{0,1}[0-9]{4}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!rx.IsMatch(txtControl.Text))
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateVehicleYear(TextBox txtControl, string msg)
        {
            Regex rx = new Regex(@"^[0-9]{4}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!rx.IsMatch(txtControl.Text))
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateDecimalNumber(TextBox txtControl, string msg)
        {
            if (txtControl.Text.Trim().Length > 0)
            {
                Regex rx = new Regex(@"^[0-9]([.,][0-9]{1,2})?$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                if (!rx.IsMatch(txtControl.Text))
                {
                    EpForm.SetError(txtControl, msg);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
        }

        public bool ValidateTicket(TextBox txtControl, string msg)
        {
            if (txtControl.Text.Trim().Length >= 8 || txtControl.Text.Trim().Length <= 10)
            {
                try
                {
                    var n = Int64.Parse(txtControl.Text);
                    return true;
                }
                catch
                {
                    EpForm.SetError(txtControl, msg);
                    return false;
                }
            }
            else
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
        }

        public bool ValidateDates(DateTimePicker dtpInit, DateTimePicker dtpEnd, string msg)
        {
            if (dtpEnd.Value <= dtpInit.Value)
            {
                EpForm.SetError(dtpEnd, msg);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateEmail(TextBox txtControl, string msg)
        {
            try
            {
                MailAddress m = new MailAddress(txtControl.Text);
                return true;
            }
            catch
            {
                EpForm.SetError(txtControl, msg);
                return false;
            }
        }
    }
}
