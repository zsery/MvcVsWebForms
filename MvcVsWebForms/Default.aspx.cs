using BLL;
using System;
using System.Data;
using Utils;

namespace WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        const string newLine = @"<br/>";
        public int EventId
        {
            get
            {
                return int.Parse(Session["EventId"].ToString());
            }
            set
            {
                Session["EventId"] = value;
            }
        }

        public string EventsSort
        {
            get
            {
                return Session["EventsSort"] == null ? "ASC" : this.Session["EventsSort"].ToString();
            }
            set
            {
                Session["EventsSort"] = value;
            }
        }


        public int LegalCase
        {
            get
            {
                return int.Parse(Session["LegalCase"].ToString());
            }
            set
            {
                Session["LegalCase"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            this.L.Text = String.Empty;

            try
            {
                // only for simulating request from parent page
                var items = new Events(true).Items.Select();
                if (!this.IsPostBack)
                {
                    EventId = int.Parse(items[0]["EventId"].ToString());
                    LegalCase = int.Parse(items[0]["CaseId"].ToString());
                }
                try
                {
                    this.f1.DataSource = new LegalCases(LegalCase);
                    this.f1.DataBind();

                    try
                    {
                        this.f2.DataSource = new Events(EventId).Items;
                        this.f2.DataBind();
                        try
                        {
                            this.LV1.DataSource = new KBI_IDS(new Debtors(LegalCase).Items).Items;
                            this.LV1.DataBind();
                            try
                            {
                                this.LV2.DataSource = new Events(LegalCase, true).ItemsFiltered;
                                this.LV2.DataBind();
                                try
                                {

                                    this.LD.Text = new Debtors(this.LegalCase).Items.Rows[0]["nazev"].ToString();
                                    try
                                    {
                                        this.f3.DataSource = new Debtors(this.LegalCase).Items;
                                        this.f3.DataBind();
                                    }
                                    catch (ValidationException validationException)
                                    {
                                        this.L.Text = this.L.Text + validationException.Message + newLine;
                                    }
                                    catch (Exception exception)
                                    {
                                        this.L.Text = this.L.Text + exception.Message + newLine;
                                    }

                                }
                                catch (ValidationException validationException)
                                {
                                    this.L.Text = this.L.Text + validationException.Message + newLine;
                                }
                                catch (Exception exception)
                                {
                                    this.L.Text = this.L.Text + exception.Message + newLine;
                                }
                            }
                            catch (ValidationException validationException)
                            {
                                this.L.Text = this.L.Text + validationException.Message + newLine;
                            }
                            catch (Exception exception)
                            {
                                this.L.Text = this.L.Text + exception.Message + newLine;
                            }
                        }
                        catch (ValidationException validationException)
                        {
                            this.L.Text = this.L.Text + validationException.Message + newLine;
                        }
                        catch (Exception exception)
                        {
                            this.L.Text = this.L.Text + exception.Message + newLine;
                        }
                    }
                    catch (ValidationException validationException)
                    {
                        this.L.Text = this.L.Text + validationException.Message + newLine;
                    }
                    catch (Exception exception)
                    {
                        this.L.Text = this.L.Text + exception.Message + newLine;
                    }

                }
                catch (ValidationException validationException)
                {
                    this.L.Text = this.L.Text + validationException.Message + newLine;
                }
                catch (Exception exception)
                {
                    this.L.Text = this.L.Text + exception.Message + newLine;
                }
            }
            catch (ValidationException validationException)
            {
                this.L.Text = this.L.Text + validationException.Message + newLine;
            }
            catch (Exception exception)
            {
                this.L.Text = this.L.Text + exception.Message + newLine;
            }
        }

        protected void LV2_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            this.L.Text = "";
            if (e.SortDirection.ToString().Substring(0, this.EventsSort.Length).ToUpper() == EventsSort)
            {
                EventsSort = "DESC";
            }
            else
            {
                EventsSort = "ASC";
            }
            try
            {
                var list = new Events(this.LegalCase, true).ItemsFiltered;
                for (int i = 2; i < this.LV2.Columns.Count; i++)
                {
                    this.LV2.Columns.Remove(this.LV2.Columns[i]);
                }
                this.LV2.DataSource = list.Select("", e.SortExpression + " " + EventsSort).CopyToDataTable();
                this.LV2.DataBind();
            }
            catch (ValidationException validationException)
            {
                this.L.Text = this.L.Text + validationException.Message + newLine;
            }
            catch (Exception exception)
            {
                this.L.Text = this.L.Text + exception.Message + newLine;
            }

        }

        protected void LV2_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.Cells.Count > 3)
            {
                e.Row.Cells[2].Visible = false;
                e.Row.Cells[3].Visible = false;
            }
        }
    }
}
