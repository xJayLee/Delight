// Internal view logic generated from "ListItem.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class ListItem : UIImageView
    {
        #region Constructors

        public ListItem(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? ListItemTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            Click.RegisterHandler(this, "ListItemMouseClick");
            MouseEnter.RegisterHandler(this, "ListItemMouseEnter");
            MouseExit.RegisterHandler(this, "ListItemMouseExit");
            MouseDown.RegisterHandler(this, "ListItemMouseDown");
            MouseUp.RegisterHandler(this, "ListItemMouseUp");
            SetListItemState = new AttachedProperty<System.Boolean>(this, "SetListItemState");
            this.AfterInitializeInternal();
        }

        public ListItem() : this(null)
        {
        }

        static ListItem()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(ListItemTemplates.Default, dependencyProperties);

            dependencyProperties.Add(ItemProperty);
            dependencyProperties.Add(IsDisabledProperty);
            dependencyProperties.Add(IsAlternateProperty);
            dependencyProperties.Add(IsSelectedProperty);
            dependencyProperties.Add(IsPressedProperty);
            dependencyProperties.Add(IsMouseOverProperty);
            dependencyProperties.Add(AutoSizeToContentProperty);
            dependencyProperties.Add(LengthProperty);
            dependencyProperties.Add(BreadthProperty);
            dependencyProperties.Add(ContentTemplateDataProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<Delight.BindableObject> ItemProperty = new DependencyProperty<Delight.BindableObject>("Item");
        public Delight.BindableObject Item
        {
            get { return ItemProperty.GetValue(this); }
            set { ItemProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsDisabledProperty = new DependencyProperty<System.Boolean>("IsDisabled");
        public System.Boolean IsDisabled
        {
            get { return IsDisabledProperty.GetValue(this); }
            set { IsDisabledProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsAlternateProperty = new DependencyProperty<System.Boolean>("IsAlternate");
        public System.Boolean IsAlternate
        {
            get { return IsAlternateProperty.GetValue(this); }
            set { IsAlternateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsSelectedProperty = new DependencyProperty<System.Boolean>("IsSelected");
        public System.Boolean IsSelected
        {
            get { return IsSelectedProperty.GetValue(this); }
            set { IsSelectedProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsPressedProperty = new DependencyProperty<System.Boolean>("IsPressed");
        public System.Boolean IsPressed
        {
            get { return IsPressedProperty.GetValue(this); }
            set { IsPressedProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> IsMouseOverProperty = new DependencyProperty<System.Boolean>("IsMouseOver");
        public System.Boolean IsMouseOver
        {
            get { return IsMouseOverProperty.GetValue(this); }
            set { IsMouseOverProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> AutoSizeToContentProperty = new DependencyProperty<System.Boolean>("AutoSizeToContent");
        public System.Boolean AutoSizeToContent
        {
            get { return AutoSizeToContentProperty.GetValue(this); }
            set { AutoSizeToContentProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementSize> LengthProperty = new DependencyProperty<Delight.ElementSize>("Length");
        public Delight.ElementSize Length
        {
            get { return LengthProperty.GetValue(this); }
            set { LengthProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementSize> BreadthProperty = new DependencyProperty<Delight.ElementSize>("Breadth");
        public Delight.ElementSize Breadth
        {
            get { return BreadthProperty.GetValue(this); }
            set { BreadthProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ContentTemplateData> ContentTemplateDataProperty = new DependencyProperty<Delight.ContentTemplateData>("ContentTemplateData");
        public Delight.ContentTemplateData ContentTemplateData
        {
            get { return ContentTemplateDataProperty.GetValue(this); }
            set { ContentTemplateDataProperty.SetValue(this, value); }
        }

        public AttachedProperty<System.Boolean> SetListItemState { get; private set; }

        #endregion
    }

    #region Data Templates

    public static class ListItemTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return ListItem;
            }
        }

        private static Template _listItem;
        public static Template ListItem
        {
            get
            {
#if UNITY_EDITOR
                if (_listItem == null || _listItem.CurrentVersion != Template.Version)
#else
                if (_listItem == null)
#endif
                {
                    _listItem = new Template(UIImageViewTemplates.UIImageView);
#if UNITY_EDITOR
                    _listItem.Name = "ListItem";
#endif
                    Delight.ListItem.AutoSizeToContentProperty.SetDefault(_listItem, true);
                    Delight.ListItem.RaycastBlockModeProperty.SetDefault(_listItem, Delight.RaycastBlockMode.Always);
                    Delight.ListItem.BreadthProperty.SetDefault(_listItem, new ElementSize(30f, ElementSizeUnit.Pixels));
                    Delight.ListItem.BackgroundColorProperty.SetDefault(_listItem, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Selected", _listItem, new UnityEngine.Color(0.9372549f, 0.4392157f, 0.4156863f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Highlighted", _listItem, new UnityEngine.Color(0.8352941f, 0.8313726f, 0.8313726f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Pressed", _listItem, new UnityEngine.Color(0.9372549f, 0.4392157f, 0.4156863f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Alternate", _listItem, new UnityEngine.Color(0.9490196f, 0.9490196f, 0.9490196f, 1f));
                }
                return _listItem;
            }
        }

        #endregion
    }

    #endregion
}
