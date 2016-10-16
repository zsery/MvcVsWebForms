<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="f" runat="server">
        <div>Detail události</div>
        <asp:Label ID="L" runat="server" Text=""></asp:Label>
        <br />
        <span>Informace o insolvenčním řízení</span>
        <asp:FormView ID="f1" runat="server">
            <EmptyDataTemplate>
                Data nenalezena
            </EmptyDataTemplate>
            <ItemTemplate>
                <table>
                    <tr>
                        <td>Spisová značka:</td>
                        <td>
                            <input type="text" value='<%# Eval("Sign") %>' disabled="disabled" />
                        </td>
                        <td>Řízení zahájeno:</td>
                        <td>
                            <input type="text" value='<%# Eval("LegalCaseIniatedAt") %>' disabled="disabled" />
                        </td>
                    </tr>
                    <tr>
                        <td>Uloženo</td>
                        <td>
                            <input type="text" value='<%# Eval("RecordSavedAt") %>' disabled="disabled" />
                        </td>
                        <td>Řízení ukončeno:</td>
                        <td>
                            <input type="text" value='<%# Eval("LegalCaseResolvedAt") %>' disabled="disabled" />
                            <input type="submit" value="T" form="f" />
                            <input type="submit" value="E" form="f" />

                        </td>
                    </tr>
                    <tr>
                        <td>Stav</td>
                        <td>
                            <span><%# Eval("State") %></span>
                        </td>
                        <td>Kód rizika (datum):</td>
                        <td>
                            <input type="text" value='<%# Eval("RiskCode") %>' disabled="disabled" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
        <br />
        <span>Informace o události</span>
        <asp:FormView ID="f2" runat="server">
            <EmptyDataTemplate>
                Data nenalezena
            </EmptyDataTemplate>
            <ItemTemplate>
                <table>
                    <tr>
                        <td>Název události:</td>
                        <td colspan="3">
                            <input type="text" value='<%# Eval("EventTypDescription") %>' disabled="disabled" />
                        </td>
                    </tr>
                    <tr>
                        <td>Identifikace údálosti</td>
                        <td>
                            <input type="text" value='ID:<%# Eval("EventId") %> Oddíl: <%# Eval("Section") %>/><%# Eval("OrderOfSection") %>' disabled="disabled" />
                        </td>
                        <td>Nabytí právní moci:</td>
                        <td>
                            <input type="text" value='<%# Eval("LegalCaseIniatedAt") %>' disabled="disabled" />
                        </td>
                    </tr>
                    <tr>
                        <td>Zveřejněno v ISIR:</td>
                        <td>
                            <input type="text" value='<%# Eval("PublishedAt") %>' disabled="disabled" />
                        </td>
                        <td>Zpracovatel:</td>
                        <td>
                            <input type="text" value='<%# Eval("Resolver") %>' disabled="disabled" />
                        </td>
                    </tr>
                    <tr>
                        <td>Staženo do KB</td>
                        <td>
                            <input type="text" value='<%# Eval("LoadedAt") %>' disabled="disabled" />
                        </td>
                        <td>Zpracováno:</td>
                        <td>
                            <input type="text" value='<%# Eval("ResolvedAt") %>' disabled="disabled" />
                        </td>
                    </tr>
                    <tr>
                        <td>Odkazy na web Msp:</td>
                        <td></td>
                        <td>Kontrolor:</td>
                        <td>
                            <input type="text" value='<%# Eval("VerifiedBy") %>' disabled="disabled" />
                        </td>
                    </tr>
                    <tr>
                        <td>Stav události:</td>
                        <td>
                            <span><%# Eval("EventStateId") %></span>
                        </td>
                        <td>Kontrolováno:</td>
                        <td>
                            <input type="text" value='<%# Eval("VerifiedAt") %>' disabled="disabled" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
        <br />
        <span>Seznam KBI Dlužníka</span>

        <asp:GridView ID="LV1" runat="server">
        </asp:GridView>

        <br />
        <span>Související události/akce</span>
        <asp:GridView ID="LV2" runat="server" AllowSorting="True" OnSorting="LV2_Sorting" OnRowDataBound="LV2_RowDataBound">
            <Columns>
                <asp:ButtonField AccessibleHeaderText="Action" ButtonType="Image" HeaderText="Action" Text="B" />
                <asp:TemplateField HeaderText="Název události">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "Default.aspx?UdalostID="+Eval("eventId") %>' Text='<%# Bind("Název_události") %>'></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <div>
            Aktuální informace o dlužníkovi           
        </div>
        <asp:Label ID="LD" runat="server">
        </asp:Label>
        &nbsp;<div id="ai">
            <asp:FormView ID="f3" runat="server">
                <EmptyDataTemplate>
                    Data nenalezena
                </EmptyDataTemplate>
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>Název dlužníka:</td>
                            <td>
                                <input type="text" value='<%# Eval("nazev") %>' disabled="disabled" />
                            </td>
                            <td>Aut. dohledání:</td>
                            <td>
                                <input type="text" value='<%# Eval("matchstatusid") %>' disabled="disabled" />
                            </td>
                            <td>Datum zrušení:</td>
                            <td>
                                <input type="text" value='<%# Eval("zruseno") %>' disabled="disabled" />
                            </td>
                            <td>
                                <input id="S3" type="submit" value="Zrušit dlužníka" />
                            </td>
                        </tr>
                        <tr>
                            <td>Rodné číslo:</td>
                            <td>
                                <input type="text" value='<%#this.Eval("rc") %>' disabled="disabled" />
                            </td>
                            <td>Datum dohledání:</td>
                            <td>
                                <input type="text" value='<%# Eval("matchdate") %>' disabled="disabled" />
                            </td>
                            <td>Potvrzení zušené:</td>
                            <td>
                                <input type="text" value='<%# Eval("delete_approved_at") %>' disabled="disabled" />
                            </td>
                            <td>
                                <input id="S3" type="submit" value="Přidat KBI" /></td>
                            </td>
                        </tr>
                        <tr>
                            <td>Datum narození:</td>
                            <td>
                                <input type="text" value='<%# Eval("datum_narozeni") %>' disabled="disabled" />
                            </td>
                            <td>Klient KB:</td>
                            <td>
                                <div>Ano</div>
                        </tr>
                        <tr>
                            <td>IČO/SWIFT/ZEČO:</td>
                            <td>
                                <input type="text" value='<%# Eval("ico") %>' disabled="disabled" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:FormView>
        </div>

    </form>
</body>
</html>
