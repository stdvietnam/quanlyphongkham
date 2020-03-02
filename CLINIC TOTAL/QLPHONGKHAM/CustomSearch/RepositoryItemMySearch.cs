using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.Popup;

namespace SearchLookupEditProblem.CustomSearch
{
    [UserRepositoryItem("MySearch")]
    public class RepositoryItemMySearch : RepositoryItemSearchLookUpEdit
    {
        public bool UseSeparator { get; set; }

        static RepositoryItemMySearch() { RegisterRepositoryItemMySearch(); }

        public RepositoryItemMySearch()
            : base()
        {
            UseSeparator = true;
        }

        public const string MyRepositoryItemLookUpEditName = "MyRepositoryItemLookUpEdit";

        public override string EditorTypeName { get { return MyRepositoryItemLookUpEditName; } }

        public static void RegisterRepositoryItemMySearch()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(MyRepositoryItemLookUpEditName,
              typeof(MySearch), typeof(RepositoryItemMySearch),
              typeof(SearchLookUpEditBaseViewInfo), new ButtonEditPainter(), true, null));
        }
        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            RepositoryItemMySearch rItem = item as RepositoryItemMySearch;
            if (rItem!= null)
                this.UseSeparator = rItem.UseSeparator;
        }

    }
    public class MySearch : SearchLookUpEdit
    {
        static MySearch() { RepositoryItemMySearch.RegisterRepositoryItemMySearch(); }

        public override string EditorTypeName { get { return RepositoryItemMySearch.MyRepositoryItemLookUpEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMySearch Properties { get { return base.Properties as RepositoryItemMySearch; } }

        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            return new myPopupSearchLookUpEditForm(this);
        }

    }

    public class myPopupSearchLookUpEditForm : PopupSearchLookUpEditForm
    {
        public myPopupSearchLookUpEditForm(SearchLookUpEdit ownerEdit) : base(ownerEdit) { }
        protected override void FindClick(string text, bool isButtonClick)
        {
            if (!(OwnerEdit.Properties as RepositoryItemMySearch).UseSeparator)
                text = string.Format("\"{0}\"", text);
            base.FindClick(text, isButtonClick);
        }
    }




}
