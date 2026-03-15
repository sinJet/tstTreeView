using System.Windows.Forms;

namespace tstTreeView
{
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private TreeNode clickedNode;

        private TreeNode FindNode(TreeNode treeNode, string searchValue)
        {
            string nodeValue = treeNode.Tag as string;
            if (nodeValue.ToLower() == searchValue.ToLower())
                return treeNode;

            foreach (TreeNode child in treeNode.Nodes)
            {
                TreeNode found = FindNode(child, searchValue);
                if (found != null)
                    return found;
            }
            return null;
        }

        private void ButtonSaveNewEle_Click(object sender, EventArgs e)
        {
            TreeViewMain.SelectedNode.Text = TextBoxNameSE.Text;
            TreeViewMain.SelectedNode.Tag = TextBoxValueSE.Text;
        }

        private void ButtonSearchEle_Click(object sender, EventArgs e)
        {
            string searchNode = TextBoxSearch.Text;
            foreach (TreeNode treeNode in TreeViewMain.Nodes)
            {
                TreeNode found = FindNode(treeNode, searchNode);
                if (found != null)
                {
                    TreeViewMain.SelectedNode = found;
                    found.Expand();
                    return;
                }
                else if(found == null)
                {
                    TextBoxNameSE.Clear();
                    TextBoxValueSE.Clear();
                }
            }
        }

        private void CtxMenuAddElement_Click(object sender, EventArgs e)
        {
            FrmDialog dlg = new FrmDialog();
            DialogResult dialogResult = dlg.ShowDialog();

            if (dialogResult == DialogResult.OK && !string.IsNullOrEmpty(dlg.InputValue))
            {
                TreeNode newNode = new TreeNode(dlg.InputName);
                newNode.Tag = dlg.InputValue;
                if (clickedNode != null)
                {
                    clickedNode.Nodes.Add(newNode);
                }
                else
                {
                    TreeViewMain.Nodes.Add(newNode);
                }
            }
        }

        private void CtxMenuRemoveElement_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = TreeViewMain.SelectedNode;
            if (selectedNode == null) return;
            TreeViewMain.Nodes.Remove(selectedNode);
            TextBoxNameSE.Clear();
            TextBoxValueSE.Clear();

        }

        private void TreeViewMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point location = e.Location;
                TreeNode treeNode = TreeViewMain.GetNodeAt(location);

                if (treeNode != null)
                {
                    TreeViewMain.SelectedNode = treeNode;
                }
                else
                {
                    TreeViewMain.SelectedNode = null;
                }
            }
        }

        private void TreeViewMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clickedNode = TreeViewMain.GetNodeAt(e.Location);
                TreeViewMain.SelectedNode = clickedNode;
                CtxMenuRemoveElement.Visible = clickedNode != null;
                TextBoxNameSE.Clear();
                TextBoxValueSE.Clear();
            }else if(e.Button == MouseButtons.Left)
            {
                TextBoxNameSE.Clear();
                TextBoxValueSE.Clear();
            }
        }

        private void TreeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TextBoxNameSE.Text = TreeViewMain.SelectedNode.Text;
            TextBoxValueSE.Text = TreeViewMain.SelectedNode.Tag as string;
        }
    }
}
