using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.XmlUnit.Builder;
using Org.XmlUnit.Diff;

namespace Kramp.DotNet.Models.CDM.Tests
{
    [TestClass]
    public class ModelsTest
    {
        private const string TestFolder = @"Reference";

        [TestMethod]
        public void TestSerializeOrder()
        {
            Order order = new Order
            {
                ID = new Identifier("1234")
            };

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("ns0", Constants.OrderNamespace);
            namespaces.Add("cac", Constants.CommonAggregateComponentsNamespace);
            namespaces.Add("cbc", Constants.CommonBasicComponentsNamespace);

            // Serialize BGM to a stringWriter
            StringWriter stringWriter = new StringWriter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
            xmlSerializer.Serialize(stringWriter, order, namespaces);

            string actualXmlString = stringWriter.ToString();
        }

        [TestMethod]
        public void TestDeserializeOrder()
        {
            string orderXml = File.ReadAllText(@$"{TestFolder}\CDMOrder.xml");
            StringReader stringReader = new StringReader(orderXml);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
            Order order = xmlSerializer.Deserialize(stringReader) as Order;
        }

        [TestMethod]
        public void TestSerializeOrderResponse()
        {
            OrderResponse orderResponse = new OrderResponse
            {
                OrderReference = new OrderReference { ID = new Identifier("2670865") },
                SellerSupplierParty = new SellerSupplierParty
                {
                    Party = new Party
                    {
                        PartyIdentification = new PartyIdentification
                        {
                            ID = new Identifier("9003170000000") { SchemeAgencyID = "9" }

                        },
                        PostalAddress = new PostalAddress
                        {
                            StreetName = new Name("Verwelkomingsstraat 17"),
                            CityName = new Name("Brussel"),
                            PostalZone = new Text("1070"),
                            Country = new Country
                            {
                                IdentificationCode = new Code("BE")
                            }
                        }
                    }
                },
                AccountingCustomerParty = new AccountingCustomerParty
                {
                    Party = new Party
                    {
                        PartyIdentification = new PartyIdentification
                        {
                            ID = new Identifier("8716106836222") { SchemeAgencyID = "9" }

                        },
                        PostalAddress = new PostalAddress
                        {
                            StreetName = new Name("ul. Skanynawska 1"),
                            CityName = new Name("STARE MIASTO"),
                            PostalZone = new Text("62-571"),
                            Country = new Country
                            {
                                IdentificationCode = new Code("PL")
                            }
                        }
                    }
                },
                Delivery = new Delivery
                {
                    DeliveryParty = new DeliveryParty
                    {
                        PartyIdentification = new PartyIdentification
                        {
                            ID = new Identifier("8716106198344") { SchemeAgencyID = "9" }

                        },
                        PostalAddress = new PostalAddress
                        {
                            StreetName = new Name("Siemensstrasse 1"),
                            CityName = new Name("Strullendorf"),
                            PostalZone = new Text("96129"),
                            Country = new Country
                            {
                                IdentificationCode = new Code("DE")
                            }
                        }
                    }
                },
                OrderLine = new OrderLine[]
                {
                    new OrderLine
                    {
                        LineItem =
                            new LineItem
                            {
                                ID = new Identifier("1"),
                                LineExtensionAmount = new Amount(23.8M, "EUR"),
                                Delivery = new Delivery
                                {
                                    Quantity = new Quantity
                                    {
                                        Value = 20,
                                        UnitCode = "PCE"
                                    },
                                    EstimatedDeliveryPeriod = new EstimatedDeliveryPeriod
                                    {
                                        StartDate = new Date ("2020-02-19")
                                    }
                                },
                                Price = new Price
                                {
                                    PriceAmount = new Amount(1.19M, "EUR"),
                                    BaseQuantity = new Quantity(1) { UnitCode = "PCE" },
                                    PriceTypeCode = new Code("AAA") { ListID = "EDIFACT" }
                                },
                                Item = new Item
                                {
                                    Description = new Text[]
                                    {
                                        new Text("27E 115x7x22,23 A24Q-BFX")
                                    },
                                    SellersItemIdentification = new ItemIdentification
                                    {
                                        ID = new Identifier("34332771")
                                    }
                                }
                        },
                        OrderLineReference = new OrderLineReference
                        {
                            LineID = new Identifier("5"),
                            OrderReference = new OrderReference
                            {
                                ID = new Identifier("2670865")
                            }
                        }
                    }
                },
            };

            // want the rootnode to be in the ns0 namespace, instead of the default namespace
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("ns0", Constants.OrderResponseNamespace);
            namespaces.Add("cac", Constants.CommonAggregateComponentsNamespace);
            namespaces.Add("cbc", Constants.CommonBasicComponentsNamespace);

            // Serialize BGM to a stringWriter
            StringWriter stringWriter = new StringWriter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderResponse));
            xmlSerializer.Serialize(stringWriter, orderResponse, namespaces);

            string actualXmlString = stringWriter.ToString();
            Diff myDiff = DiffBuilder.Compare(Input.FromString(actualXmlString))
                           .WithTest(Input.FromFile($@"{TestFolder}\CDMOrderResponse.xml")).CheckForSimilar()
                           .Build();

            Assert.IsFalse(myDiff.HasDifferences(), "CheckForSimilar");
        }


        [TestMethod]
        public void TestDeserializeOrderResponse()
        {
            string orderResponseXml = File.ReadAllText(@$"{TestFolder}\CDMOrderResponse.xml");
            StringReader stringReader = new StringReader(orderResponseXml);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderResponse));
            OrderResponse orderResponse = xmlSerializer.Deserialize(stringReader) as OrderResponse;
            Assert.IsNotNull(orderResponse);
            Assert.IsNotNull(orderResponse.OrderReference.ID);
            Assert.IsNotNull(orderResponse.SellerSupplierParty.Party.PartyIdentification.ID);
            Assert.IsNotNull(orderResponse.SellerSupplierParty.Party.PartyIdentification.ID.SchemeAgencyID);
            Assert.IsNotNull(orderResponse.SellerSupplierParty.Party.PostalAddress.StreetName);
            Assert.IsNotNull(orderResponse.AccountingCustomerParty.Party.PartyIdentification.ID);
            Assert.IsNotNull(orderResponse.AccountingCustomerParty.Party.PartyIdentification.ID.SchemeAgencyID);
            Assert.IsNotNull(orderResponse.AccountingCustomerParty.Party.PostalAddress.StreetName);
            Assert.IsNotNull(orderResponse.Delivery.DeliveryParty.PartyIdentification.ID);
            Assert.IsNotNull(orderResponse.Delivery.DeliveryParty.PostalAddress.StreetName);
            
            Assert.AreEqual(1, orderResponse.OrderLine.Count());
            Assert.IsNotNull(orderResponse.OrderLine[0].LineItem);

            LineItem lineItem = orderResponse.OrderLine[0].LineItem;
            Assert.IsNotNull(lineItem);
            Assert.IsNotNull(lineItem.ID);
            Assert.IsNotNull(lineItem.LineExtensionAmount);
            Assert.IsNotNull(lineItem.Delivery.Quantity);
            Assert.IsNotNull(lineItem.Delivery.EstimatedDeliveryPeriod.StartDate);
            Assert.IsNotNull(lineItem.Price.PriceAmount);
            Assert.IsNotNull(lineItem.Price.PriceAmount.CurrencyID);
            Assert.IsNotNull(lineItem.Price.BaseQuantity);
            Assert.IsNotNull(lineItem.Price.BaseQuantity.UnitCode);
            Assert.IsNotNull(lineItem.Item.Description);
            Assert.IsNotNull(lineItem.Item.SellersItemIdentification.ID);
        }
        [TestMethod]
        public void TestInvoice()
        {
            try
            {
                //Deserialize Invoice
                string invoiceXML = File.ReadAllText($@"{TestFolder}\PurchaseInvoice_CDM_INA-GB_206681597.xml");
                StringReader stringReader = new StringReader(invoiceXML);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Invoice));
                Invoice invoice = xmlSerializer.Deserialize(stringReader) as Invoice;

                //Serialize the invoice object
                // want the rootnode to be in the ns0 namespace, instead of the default namespace
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add("ns0", Constants.InvoiceNamespace);
                namespaces.Add("cac", Constants.CommonAggregateComponentsNamespace);
                namespaces.Add("cbc", Constants.CommonBasicComponentsNamespace);

                // Serialize BGM to a stringWriter
                StringWriter stringWriter = new StringWriter();
                XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Invoice));
                xmlSerializer2.Serialize(stringWriter, invoice, namespaces);

                string actualInvoiceXmlString = stringWriter.ToString();


                Diff myDiff = DiffBuilder.Compare(Input.FromString(actualInvoiceXmlString))
                               .WithTest(invoiceXML).CheckForSimilar()
                               .Build();

                // Assert.IsFalse(myDiff.HasDifferences(), "CheckForSimilar");
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void TestCreditNote()
        {
            try
            {
                //Deserialize CreditNote
                string creditNoteXML = File.ReadAllText($@"{TestFolder}\CDMCreditNote.xml");
                StringReader stringReader = new StringReader(creditNoteXML);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(CreditNote));
                CreditNote creditNote = xmlSerializer.Deserialize(stringReader) as CreditNote;

                //Serialize the invoice object
                // want the rootnode to be in the ns0 namespace, instead of the default namespace
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add("ns0", Constants.CreditNoteNamespace);
                namespaces.Add("cac", Constants.CommonAggregateComponentsNamespace);
                namespaces.Add("cbc", Constants.CommonBasicComponentsNamespace);

                // Serialize BGM to a stringWriter
                StringWriter stringWriter = new StringWriter();
                XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(CreditNote));
                xmlSerializer2.Serialize(stringWriter, creditNote, namespaces);

                string actualCreditNoteXMLString = stringWriter.ToString();


                Diff myDiff = DiffBuilder.Compare(Input.FromString(actualCreditNoteXMLString))
                               .WithTest(creditNoteXML).CheckForSimilar()
                               .Build();

                Assert.IsFalse(myDiff.HasDifferences(), "CheckForSimilar");
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void TestDespatchNote()
        {
            try
            {
                //Deserialize DespatchNote
                string despatchXML = File.ReadAllText($@"{TestFolder}\CDMDespatchAdvice.xml");
                StringReader stringReader = new StringReader(despatchXML);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DespatchAdvice));
                DespatchAdvice despatchAdvice = xmlSerializer.Deserialize(stringReader) as DespatchAdvice;

                //Serialize the invoice object
                // want the rootnode to be in the ns0 namespace, instead of the default namespace
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add("ns0", Constants.DespatchAdviceNamespace);
                namespaces.Add("cac", Constants.CommonAggregateComponentsNamespace);
                namespaces.Add("cbc", Constants.CommonBasicComponentsNamespace);

                // Serialize BGM to a stringWriter
                StringWriter stringWriter = new StringWriter();
                XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(DespatchAdvice));
                xmlSerializer2.Serialize(stringWriter, despatchAdvice, namespaces);

                string actualDespatchXMLXmlString = stringWriter.ToString();


                Diff myDiff = DiffBuilder.Compare(Input.FromString(actualDespatchXMLXmlString))
                               .WithTest(despatchXML).CheckForSimilar()
                               .Build();

                Assert.IsFalse(myDiff.HasDifferences(), "CheckForSimilar");
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void SerializeInvoiceLine()
        {
            InvoiceLine invoiceLine = new InvoiceLine();
            invoiceLine.ID = new Identifier("10");

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", Constants.InvoiceNamespace);
            namespaces.Add("cac", Constants.CommonAggregateComponentsNamespace);
            namespaces.Add("cbc", Constants.CommonBasicComponentsNamespace);

            XmlSerializer serializer = new XmlSerializer(typeof(InvoiceLine));
            StringWriter invoiceLineStringWriter = new StringWriter();
            serializer.Serialize(invoiceLineStringWriter, invoiceLine, namespaces);
            string invoiceLineXml = invoiceLineStringWriter.ToString();
        }

        [TestMethod]
        public void SerializeInvoice()
        {
            Invoice invoice = new Invoice();
            invoice.InvoiceLine = new InvoiceLine[] { new InvoiceLine { ID = new Identifier("10") } };

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", Constants.InvoiceNamespace);
            namespaces.Add("cac", Constants.CommonAggregateComponentsNamespace);
            namespaces.Add("cbc", Constants.CommonBasicComponentsNamespace);

            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
            StringWriter invoiceStringWriter = new StringWriter();
            serializer.Serialize(invoiceStringWriter, invoice, namespaces);
            string invoiceXml = invoiceStringWriter.ToString();
        }
    }
}
