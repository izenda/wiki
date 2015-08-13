#CollapsiblePanelPartDesigner

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|DesignerActionListCollection|[[ActionLists|http://msdn.microsoft.com/en-us/library/68wxa8w3]]| Gets the action list collection for the control designer. |{null}|
|Boolean|[[AllowResize|/API/Izenda/Controls/Design/CodeSamples/Izenda_Controls_Design_CollapsiblePanelPartDesigner_AllowResize]]||False|
|ICollection|[[AssociatedComponents|http://msdn.microsoft.com/en-us/library/fs87wbxy]]| Gets the collection of components associated with the component managed by the designer. |[]|
|DesignerAutoFormatCollection|[[AutoFormats|http://msdn.microsoft.com/en-us/library/w2e2zae6]]| Gets the collection of predefined automatic formatting schemes to display in the Auto Format dialog box for the associated control at design time.  |null|
|IHtmlControlDesignerBehavior|[[Behavior|http://msdn.microsoft.com/en-us/library/t045k49w]]| Gets or sets the DHTML behavior that is associated with the designer. **(deprecated)**|null|
|IComponent|[[Component|http://msdn.microsoft.com/en-us/library/tzw18hkk]]| Gets the component this designer is designing. |null|
|DataBindingCollection|[[DataBindings|http://msdn.microsoft.com/en-us/library/78a0t5za]]| Gets the data bindings collection for the current control. |null|
|Boolean|[[DesignTimeHtmlRequiresLoadComplete|http://msdn.microsoft.com/en-us/library/kw8eddyf]]| Gets a value indicating whether the design host must finish loading before the Overload:System.Web.UI.Design.ControlDesigner.GetDesignTimeHtml method can be called. **(deprecated)**|False|
|ExpressionBindingCollection|[[Expressions|http://msdn.microsoft.com/en-us/library/fxae1f7y]]| Gets the expression bindings for the current control at design time. |null|
|String|[[FrameCaption|http://msdn.microsoft.com/en-us/library/dfh3ef95]]| Gets the caption that is displayed for a control at design time. |null|
|Style|[[FrameStyle|http://msdn.microsoft.com/en-us/library/a4h1057s]]| Gets the style that is applied to the control frame at design time. |null|
|String|[[ID|http://msdn.microsoft.com/en-us/library/d0xtba56]]| Gets or sets the ID string for the control. |null|
|Boolean|[[IsDirty|http://msdn.microsoft.com/en-us/library/wt9e77y7]]| Gets or sets a value indicating whether the Web server control has been marked as changed. **(deprecated)**|False|
|Boolean|[[ReadOnly|http://msdn.microsoft.com/en-us/library/2bc75346]]| Gets or sets a value indicating whether the properties of the control are read-only at design time. **(deprecated)**|True|
|Boolean|[[ShouldCodeSerialize|http://msdn.microsoft.com/en-us/library/k42t5bc3]]| Gets or sets a value indicating whether to create a field declaration for the control in the code-behind file for the current design document during serialization. **(deprecated)**|True|
|TemplateGroupCollection|[[TemplateGroups|http://msdn.microsoft.com/en-us/library/shs24kwh]]| Gets a collection of template groups, each containing one or more template definitions. |null|
|DesignerVerbCollection|[[Verbs|http://msdn.microsoft.com/en-us/library/3883f5x2]]| Gets the design-time verbs supported by the component that is associated with the designer. |{}|
|Control|[[ViewControl|http://msdn.microsoft.com/en-us/library/k3tz2hcy]]| Gets or sets a Web server control that can be used for previewing the design-time HTML markup. |null|
|Boolean|[[ViewControlCreated|http://msdn.microsoft.com/en-us/library/ms153759]]| Gets or sets a value indicating whether a View control has been created for display on the design surface. |False|


##Methods

###Dispose()
Releases all resources used by the [[System.ComponentModel.Design.ComponentDesigner|http://msdn.microsoft.com/en-us/library/72ea7ss5]].






---


###DoDefaultAction()
 Creates a method signature in the source code file for the default event on the component and navigates the user's cursor to that location. 






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetBounds()
 Retrieves the coordinates of the rectangle representing the boundaries for the control as displayed on the design surface. 





Returns:

A [[System.Drawing.Rectangle|http://msdn.microsoft.com/en-us/library/1zk39146]] object representing the boundaries for the control on the design surface relative to the control, not the document.


---


###GetDesignTimeCssAttributes()
 Returns the collection of style attributes for the control at design time. 





Returns:

A collection of style attributes applied to the control on the design surface. The style attribute names are keys used to access the style attribute values in the [[System.Collections.IDictionary|http://msdn.microsoft.com/en-us/library/9dhwsays]].


---


###GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection)
 Returns the HTML markup that is used to represent the control at design time. 

Parameters: 

* [[System.Web.UI.Design.DesignerRegionCollection|http://msdn.microsoft.com/en-us/library/akt2zx16]] regions  -  A collection of designer regions. 





Returns:

 An HTML markup string that represents the control. 


---


###GetDesignTimeHtml()
 Retrieves the HTML markup that is used to represent the control at design time. 





Returns:

 The HTML markup used to represent the control at design time. 


---


###GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion)
 Returns the content for the editable region of the control at design time. 

Parameters: 

* [[System.Web.UI.Design.EditableDesignerRegion|http://msdn.microsoft.com/en-us/library/x6h6d5y4]] region  -  An editable design region contained within the control. 





Returns:

The persisted content of the region contained within the [[System.Web.UI.Design.ContainerControlDesigner|http://msdn.microsoft.com/en-us/library/b3xyd70s]].


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetPersistenceContent()
 Returns the persistable content of the control at design time. 





Returns:

null. 


---


###GetPersistInnerHtml()
 Retrieves the persistable inner HTML markup of the control. **(deprecated)**





Returns:

 The persistable inner HTML markup of the control. 


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetViewRendering()
 Retrieves an object that contains the design-time markup for the content and regions of the associated control. 





Returns:

A [[System.Web.UI.Design.ViewRendering|http://msdn.microsoft.com/en-us/library/wc6edf1b]] object.


---


###Initialize(System.ComponentModel.IComponent)
 Initializes the control designer and loads the specified component. 

Parameters: 

* [[System.ComponentModel.IComponent|http://msdn.microsoft.com/en-us/library/e4w667z9]] component  -  The control being designed.  






---


###InitializeExistingComponent(System.Collections.IDictionary)
 Reinitializes an existing component. 

Parameters: 

* [[System.Collections.IDictionary|http://msdn.microsoft.com/en-us/library/9dhwsays]] defaultValues  -  A name/value dictionary of default values to apply to properties. May be null if no default values are specified. 






---


###InitializeNewComponent(System.Collections.IDictionary)
 Initializes a newly created component. 

Parameters: 

* [[System.Collections.IDictionary|http://msdn.microsoft.com/en-us/library/9dhwsays]] defaultValues  -  A name/value dictionary of default values to apply to properties. May be null if no default values are specified. 






---


###InitializeNonDefault()
 Initializes the settings for an imported component that is already initialized to settings other than the defaults. **(deprecated)**






---


###Invalidate()
 Invalidates the whole area of the control that is displayed on the design surface and signals the control designer to redraw the control. 






---


###Invalidate(System.Drawing.Rectangle)
 Invalidates the specified area of the control that is displayed on the design surface and signals the control designer to redraw the control. 

Parameters: 

* [[System.Drawing.Rectangle|http://msdn.microsoft.com/en-us/library/1zk39146]] rectangle  - A [[System.Drawing.Rectangle|http://msdn.microsoft.com/en-us/library/1zk39146]] object that represents the area to invalidate, relative to the upper-left corner of the control.






---


###IsPropertyBound(System.String)
 Retrieves a value indicating whether the specified property on the associated control is data-bound. **(deprecated)**

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] propName  -  The property to test for data binding.  





Returns:

true, if the property is data-bound; otherwise, false. 


---


###Localize(System.Web.UI.Design.IDesignTimeResourceWriter)
 Uses the provided resource writer to persist the localizable properties of the associated control to a resource in the design host. 

Parameters: 

* [[System.Web.UI.Design.IDesignTimeResourceWriter|http://msdn.microsoft.com/en-us/library/96ya74tk]] resourceWriter  - An object derived from the [[System.Web.UI.Design.IDesignTimeResourceWriter|http://msdn.microsoft.com/en-us/library/96ya74tk]] object that is used to write resources into the design-time response stream.






---


###OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat)
 Called when a predefined, automatic formatting scheme has been applied to the associated control. 

Parameters: 

* [[System.Web.UI.Design.DesignerAutoFormat|http://msdn.microsoft.com/en-us/library/stwdk5by]] appliedAutoFormat  - A [[System.Web.UI.Design.DesignerAutoFormat|http://msdn.microsoft.com/en-us/library/stwdk5by]] object that defines a style.






---


###OnComponentChanged(System.Object,System.ComponentModel.Design.ComponentChangedEventArgs)
 Called when the associated control changes. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender  -  The source of the event.  
* [[System.ComponentModel.Design.ComponentChangedEventArgs|http://msdn.microsoft.com/en-us/library/ya0b5665]] ce  - A [[System.ComponentModel.Design.ComponentChangedEventArgs|http://msdn.microsoft.com/en-us/library/ya0b5665]] object that contains the event data.






---


###OnComponentChanging(System.Object,System.ComponentModel.Design.ComponentChangingEventArgs)
 Represents the method that will handle the System.ComponentModel.Design.IComponentChangeService.ComponentChanging event for the associated control.  

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender  -  The object that is the source of the event. 
* [[System.ComponentModel.Design.ComponentChangingEventArgs|http://msdn.microsoft.com/en-us/library/d9tshh6z]] ce  - A [[System.ComponentModel.Design.ComponentChangedEventArgs|http://msdn.microsoft.com/en-us/library/ya0b5665]] object that contains the event data.






---


###OnSetComponentDefaults()
 Sets the default properties for the component. **(deprecated)**






---


###OnSetParent()
 Provides a way to perform additional processing when the associated control is attached to a parent control. 






---


###RaiseResizeEvent()
 Raises the System.Web.UI.Design.ControlDesigner.OnControlResize event. **(deprecated)**






---


###RegisterClone(System.Object,System.Object)
 Registers internal data in a cloned control. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] original  -  The control associated with the control designer. 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] clone  -  The cloned copy of the associated control. 






---


###SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion,System.String)
 Sets the content for the editable region of the control at design time. 

Parameters: 

* [[System.Web.UI.Design.EditableDesignerRegion|http://msdn.microsoft.com/en-us/library/x6h6d5y4]] region  -  An editable design region contained within the control. 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] content  -  Content to assign for the editable design region. 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###UpdateDesignTimeHtml()
 Refreshes the design-time HTML markup for the associated Web server control by calling the Overload:System.Web.UI.Design.ControlDesigner.GetDesignTimeHtml method. 






---


