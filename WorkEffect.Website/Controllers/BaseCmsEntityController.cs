using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseCmsEntityController<T> : BaseCmsController where T: BaseEntity, new()
    {
        // behaviour
        public bool AfterCreate_ShowDetails = false;
        
        /* ---------------------------------------------------------------------------------------------------------
         * List entities
         * --------------------------------------------------------------------------------------------------------- */

        /// <summary>
        /// Gets the Index view.
        /// </summary>
        /// <param name="festivalID">The festival ID.</param>
        /// <returns></returns>
        public virtual ViewResult Index(int festivalID)
        {
            return View(GetList(festivalID));
        }
        
        /// <summary>
        /// Gets the entities to display in the Index view.
        /// </summary>
        /// <param name="festivalID">The festival ID.</param>
        /// <returns></returns>
        public virtual List<T> GetList(int festivalID) {
            return Context.Set<T>().ToList();
        }


        /// <summary>
        /// Gets specified entity.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public virtual T GetEntity(int id)
        {
            return Context.Set<T>().First(x => x.Id == id);
        }


        /* ---------------------------------------------------------------------------------------------------------
         * View an entity
         * --------------------------------------------------------------------------------------------------------- */

        /// <summary>
        /// Gets the entity Details view.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public virtual ViewResult Details(int id)
        {
            var model = GetEntity(id);
            return View(model);
        }


        /* ---------------------------------------------------------------------------------------------------------
         * Create a new entity
         * --------------------------------------------------------------------------------------------------------- */

        /// <summary>
        /// Gets the Create entity view.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <returns></returns>
        public virtual ActionResult Create(int? parentID = 0)
        {
            var model = new T();
            OnCreate(model, parentID.GetValueOrDefault());
            return View(model);
        }

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public virtual ActionResult Create(T model, FormCollection data)
        {
            UpdateModel(model, data);
            if (ModelState.IsValid)
            {
                Context.Set<T>().Add(model);
                OnCreated(model);
                Context.SaveChanges();

                if (AfterCreate_ShowDetails)
                {
                    return Redirect("Details");
                }

                return Redirect("Index");
            }
            
            return View(model);
        }


        /// <summary>
        /// Called when a new entity is being created, right before PopulateViewBag is called.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="parentID">The parent ID.</param>
        public virtual void OnCreate(T model, int parentID)
        {
        }

        /// <summary>
        /// Called when a new entity is about to be saved to the database.
        /// </summary>
        /// <param name="model">The model.</param>
        public virtual void OnCreated(T model)
        {
        }


        /* ---------------------------------------------------------------------------------------------------------
         * Edit an entity
         * --------------------------------------------------------------------------------------------------------- */

        /// <summary>
        /// Gets the Edit entity view.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public virtual ActionResult Edit(int id)
        {
            var model = GetEntity(id);
            OnEdit(model);
            return View(model);
        }

        /// <summary>
        /// Saves the changes to the specified entity.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public virtual ActionResult Edit(int id, FormCollection data)
        {
            var model = GetEntity(id);

            UpdateModel(model, data);
            if (ModelState.IsValid)
            {
                OnEdited(model);
                Context.SaveChanges();
                return Redirect("Index");
            }
            
            return View(model);
        }

        /// <summary>
        /// Called when a new entity is being edited, right before PopulateViewBag is called.
        /// </summary>
        /// <param name="model">The model.</param>
        public virtual void OnEdit(T model)
        {
        }

        /// <summary>
        /// Called when a changed entity is about to be saved to the database.
        /// </summary>
        /// <param name="model">The model.</param>
        public virtual void OnEdited(T model)
        {
        }


        /* ---------------------------------------------------------------------------------------------------------
         * Delete an entity
         * --------------------------------------------------------------------------------------------------------- */

        /// <summary>
        /// Gets the Delete entity view.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public virtual ActionResult Delete(int id)
        {
            var model = GetEntity(id);
            OnDelete(model);
            return View(model);
        }


        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            var model = GetEntity(id);
            Context.Set<T>().Remove(model);
            OnDeleted(model);
            Context.SaveChanges();
            return Redirect("Index");
        }


        /// <summary>
        /// Called when an entity is being deleted, right before PopulateViewBag is called.
        /// </summary>
        /// <param name="model">The model.</param>
        public virtual void OnDelete(T model)
        {
        }

        /// <summary>
        /// Called when a deleted entity is about to be saved to the database.
        /// </summary>
        /// <param name="model">The model.</param>
        public virtual void OnDeleted(T model)
        {
        }


        /* ---------------------------------------------------------------------------------------------------------
         * Helpers
         * --------------------------------------------------------------------------------------------------------- */

        /// <summary>
        /// Maps the form to model. calls TryUpdateModel by default.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public virtual bool UpdateModel(T model, FormCollection data)
        {
            bool isValid = base.TryUpdateModel(model, data);

            // TODO: extend validation

            return isValid;
        }


        /// <summary>
        /// Tries to update a model that was created through reflection, e.g. is of type "object".
        /// </summary>
        /// <param name="modelType">Type of the entity.</param>
        /// <param name="model">The model.</param>
        /// <param name="prefix">The prefix.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <param name="valueProvider">The value provider.</param>
        /// <returns></returns>
        private bool TryUpdateReflectedModel(Type modelType, object model, string prefix, string[] includeProperties, IValueProvider valueProvider)
        {
            // code from https://github.com/ASP-NET-MVC/aspnetwebstack/blob/master/src/System.Web.Mvc/Controller.cs#L648
            // also see http://prideparrot.com/blog/archive/2012/6/gotchas_in_explicit_model_binding

            Predicate<string> propertyFilter = propertyName => includeProperties.Contains(propertyName);
            var binder = Binders.GetBinder(modelType);

            ModelBindingContext bindingContext = new ModelBindingContext()
            {
                ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(() => model, modelType),
                ModelName = prefix,
                ModelState = ModelState,
                PropertyFilter = propertyFilter,
                ValueProvider = valueProvider
            };
            binder.BindModel(ControllerContext, bindingContext);
            return ModelState.IsValid;
        }
    }
}