import React, { Component } from 'react'

export default class Menu extends Component {
    render() {
        return (
          <div>
  <aside className="main-sidebar">
    {/* sidebar: style can be found in sidebar.less */}
    <section className="sidebar">
      {/* Sidebar user panel */}
      <div className="user-panel">
        <div className="pull-left image">
          <img src="dist/img/Tutor.png" className="img-circle" alt="User Image" />
        </div>
        <div className="pull-left info">
          <p>Admin admin</p>
          <a href="#"><i className="fa fa-circle text-green" /> Online</a>
        </div>
      </div>
      {/* search form */}
      <form action="#" method="get" className="sidebar-form">
        <div className="input-group">
          <input type="text" name="q" className="form-control" placeholder="Search..." />
          <span className="input-group-btn">
            <button type="submit" name="search" id="search-btn" className="btn btn-flat">
              <i className="fa fa-search" />
            </button>
          </span>
        </div>
      </form>
      {/* /.search form */}
      {/* sidebar menu: : style can be found in sidebar.less */}
      <ul className="sidebar-menu" data-widget="tree">
        <li className="header">DASHBOARD</li>
        <li className="active treeview menu-open">
          <a href="#">
            <i className="fa fa-user" /> <span>Utenti</span>
            <span className="pull-right-container">
              <i className="fa fa-angle-left pull-right" />
            </span>
          </a>
          <ul className="treeview-menu">
            <li><a href="userList.html"><i className="fa fa-user" />Lista users</a></li>
          </ul>
        </li>
        <li className="active treeview menu-open">
          <a href="#">
            <i className="fa fa-user-circle" /> <span>Candidati</span>
            <span className="pull-right-container">
              <i className="fa fa-angle-left pull-right" />
            </span>
          </a>
          <ul className="treeview-menu">
            <li><a href="candList.html"><i className="fa fa-user-circle" /> Lista candidati</a></li>
            <li className="active"><a href="QuestList.html"><i className="fa fa-vcard-o" /> Lista Questionari</a></li>
          </ul>
        </li>
        <li className="active treeview menu-open">
          <a href="#">
            <i className="fa fa-user-circle-o" /> <span>Aziende</span>
            <span className="pull-right-container">
              <i className="fa fa-angle-left pull-right" />
            </span>
          </a>
          <ul className="treeview-menu">
            <li><a href="compList.html"><i className="fa fa-user-circle-o" /> Lista aziende</a></li>
            <li className="active"><a href="jobList.html"><i className="fa fa-handshake-o" /> Lista Open Jobs</a></li>
          </ul>
        </li>
        <li className="header">LABELS</li>
        <li><a href="#"><i className="fa fa-circle-o text-green" /> <span>Important</span></a></li>
        <li><a href="#"><i className="fa fa-circle-o text-white" /> <span>Warning</span></a></li>
        <li><a href="#"><i className="fa fa-circle-o text-red" /> <span>Information</span></a></li>
      </ul>
    </section>
    {/* /.sidebar */}
  </aside>
</div>

        )
    }
}