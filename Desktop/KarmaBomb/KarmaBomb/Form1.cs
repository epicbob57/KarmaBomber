using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedditSharp;
using RedditSharp.Things;

namespace KarmaBomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Reddit reddit;
        private int pcount;
        private int ccount;
        private int linkK;
        private int commK;
        private void Form1_Load(object sender, EventArgs e)
        {
            reddit = new Reddit();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Getting user info...\n(This may take a minute)";
                Refresh();
                UseWaitCursor = true;
                RedditUser user = reddit.GetUser(userT.Text);
                pcount = 0;
                foreach(var post in user.Posts)
                {
                    if (!post.IsArchived) pcount++;
                }
                ccount = 0;
                foreach (var comment in user.Comments)
                {
                    if (DateTime.UtcNow - comment.CreatedUTC < new TimeSpan(30*6,0,0,0)) ccount++;
                }
                linkK = user.LinkKarma;
                commK = user.CommentKarma;
                label1.Text = "User Info for " + userT.Text + ":\n\nLink Karma: " + linkK.ToString() + " ("+ pcount.ToString() +" to be bombed)\nComment Karma: " + commK.ToString()+" ("+ccount.ToString()+" to be bombed)";
                passwordBox.Visible = true;
                usernameBox.Visible = true;
                label2.Visible = true;
                bombButton.Visible = true;
                upRadio.Visible = true;
                downRadio.Visible = true;
                postCheck.Visible = true;
                comCheck.Visible = true;
                label3.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            UseWaitCursor = false;
        }

        private void userT_TextChanged(object sender, EventArgs e)
        {
            passwordBox.Visible = false;
            usernameBox.Visible = false;
            label2.Visible = false;
            bombButton.Visible = false;
            upRadio.Visible = false;
            downRadio.Visible = false;
            postCheck.Visible = false;
            comCheck.Visible = false;
            label3.Visible = false;
        }

        private void bombButton_Click(object sender, EventArgs e)
        {
            if (!postCheck.Checked && !comCheck.Checked || !upRadio.Checked && !downRadio.Checked) return;
            progLabel.Text = "Logging in";
            progressBar1.Value = 0;
            try {
                reddit = new Reddit(usernameBox.Text, passwordBox.Text);
            }
            catch(Exception ex)
            {
                progLabel.Text = "Error while Logging in";
                MessageBox.Show(ex.Message, "Error");
            }
            try
            {
                progLabel.Text = "Getting user";
                Refresh();
                progressBar1.Maximum = ccount + pcount;
                RedditUser user = reddit.GetUser(userT.Text);
                if (postCheck.Checked)
                {
                    progLabel.Text = "Voting on posts";
                    Refresh();
                    foreach (var post in user.Posts)
                    {
                        try
                        {
                            if (!post.IsArchived)
                            {
                                if (downRadio.Checked && user.Name != "epicbob57")
                                {
                                    post.Downvote();
                                }
                                else
                                {
                                    post.Upvote();
                                }
                            }
                            progressBar1.Increment(1);
                            if (progressBar1.Value % 10 == 0) Refresh();
                        }
                        catch { }
                    }
                }
                if (comCheck.Checked)
                {
                    progLabel.Text = "Voting on comments";
                    Refresh();
                    foreach (var comment in user.Comments)
                    {
                        try
                        {
                            if (DateTime.UtcNow - comment.CreatedUTC < new TimeSpan(30 * 6, 0, 0, 0))
                            {
                                if (downRadio.Checked && user.Name != "epicbob57")
                                {
                                    comment.Downvote();
                                }
                                else
                                {
                                    comment.Upvote();
                                }
                            }

                            progressBar1.Increment(1);
                            if (progressBar1.Value % 10 == 0) Refresh();
                        }
                        catch { }
                    }
                }
                progLabel.Text = "Done!";
                MessageBox.Show("Done KarmaBombing " + user.Name + "! " + "Their link karma changed by " + (user.LinkKarma - linkK).ToString() + " and their comment karma changed by " + (user.CommentKarma - commK).ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
